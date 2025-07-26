using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Deactivator : MonoBehaviour
{
    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
        
        _collider.isTrigger = true;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Enemy>(out _) == false) 
            return;
        
        other.gameObject.SetActive(false);
    }
}
