using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    
    private Vector3 _currentDirection;
    
    private void Update()
    {
        Move();
    }

    private void OnEnable()
    {
        StartCoroutine(Debuger());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
    
    public void SetDirection(Vector3 direction)
    {
        _currentDirection = direction;
        Debug.Log($"Полученное направление: {direction}");
        Debug.Log($"Текущие направление: {_currentDirection}");
    }
    
    private void Move()
    {
        transform.position += _speed * Time.deltaTime * _currentDirection;
    }

    private IEnumerator Debuger()
    {
        Debug.Log("Корутина запустилась");
        
        while (enabled)
        {
            yield return new WaitForSeconds(1f);
            
            Debug.Log($"Направление в работе: {_currentDirection}");
        }
    }
}
