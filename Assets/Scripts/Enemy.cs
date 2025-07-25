using UnityEngine;

[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Mover _mover;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _mover = GetComponent<Mover>();
    }

    public void Initialize(Vector3 direction)
    {
        _mover.SetDirection(direction);
    }
    
    public void ResetDefaults()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;

        _rigidbody.linearVelocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
    }
}