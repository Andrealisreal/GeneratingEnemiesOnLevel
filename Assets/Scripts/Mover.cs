using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    
    private Vector3 _currentDirection;
    
    private void Update()
    {
        Move();
    }
    
    public void SetDirection(Vector3 direction)
    {
        _currentDirection = direction;
    }
    
    private void Move()
    {
        transform.position += _speed * Time.deltaTime * _currentDirection;
    }
}