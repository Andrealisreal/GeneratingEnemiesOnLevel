using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Diactivater : MonoBehaviour
{
    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
        
        _collider.isTrigger = true;
    }
}
