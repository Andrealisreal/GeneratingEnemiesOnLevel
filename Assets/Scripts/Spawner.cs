using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;
    [SerializeField] private int _spawnDelay = 2;
        
    private Vector3[] _directions;
    private EnemyPool _enemyPool;

    private void Awake()
    {
        _enemyPool = GetComponent<EnemyPool>();
        _directions = new Vector3[] { transform.forward, transform.right, -transform.forward, -transform.right };
    }

    private void OnEnable()
    {
        StartCoroutine(DelaySpawning());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
    
    private void SpawnEnemy()
    {
        var enemy = _enemyPool.GetEnemy();
        var randomPoint = _points[Random.Range(0, _points.Count)];
        var randomDirection = _directions[Random.Range(0, _directions.Length)];

        enemy.transform.position = randomPoint.transform.position + new Vector3(0, 1, 0);
        enemy.Initialize(randomDirection);
    }

    private IEnumerator DelaySpawning()
    {
        WaitForSeconds wait = new(_spawnDelay);

        while (enabled)
        {
            yield return wait;

            SpawnEnemy();
        }
    }
}