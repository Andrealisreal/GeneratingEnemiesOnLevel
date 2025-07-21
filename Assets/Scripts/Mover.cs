using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private float _time = 5f;

    private WaitForSeconds _wait;
    private Vector3[] _directions;
    private int _currentDirection = 0;

    private void Awake()
    {
        _wait = new(_time);
        _directions = new Vector3[] { transform.forward, transform.right }; ;
    }

    private void Update()
    {
        Move(_directions[_currentDirection]);
    }

    private void OnEnable()
    {
        StartCoroutine(ChangeDirection());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private void Move(Vector3 direction)
    {
        transform.position += _speed * Time.deltaTime * direction;
    }

    private IEnumerator ChangeDirection()
    {
        Debug.Log("Первый старт корутины");
        int currentDirection = 0;

        while (enabled)
        {
            Debug.Log("Вошли в цикл");
            yield return _wait;

            _currentDirection = (currentDirection + 1) % _directions.Length;

            Debug.Log("Выполнили команду");
        }
    }
}
