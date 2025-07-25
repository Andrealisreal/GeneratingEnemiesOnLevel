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
}
