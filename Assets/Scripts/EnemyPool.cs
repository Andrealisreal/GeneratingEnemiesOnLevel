using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private Enemy _prefabEnemy;
    [SerializeField] private int _sizePool = 10;

    private List<Enemy> _pool;

    private void Awake()
    {
        _pool = new List<Enemy>();
        StartCoroutine(CreatePool());
    }

    public Enemy GetEnemy()
    {
        foreach (Enemy enemy in _pool)
        {
            if (enemy.gameObject.activeInHierarchy == false)
            {
                enemy.gameObject.SetActive(true);
                enemy.ResetDefaults();

                return enemy;
            }
        }

        var newEnemy = CreateEnemy();
        newEnemy.ResetDefaults();
        
        return newEnemy;
    }

    private Enemy CreateEnemy()
    {
        var enemy = Instantiate(_prefabEnemy);
        enemy.gameObject.SetActive(false);
        _pool.Add(enemy);

        return enemy;
    }

    private IEnumerator CreatePool()
    {
        for (var i = 0; i < _sizePool; i++)
        {
            CreateEnemy();

            yield return null;
        }
    }
}
