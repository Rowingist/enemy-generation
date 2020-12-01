using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    
    [SerializeField] private GameObject _enemyTemplate;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;
    private int _currentPoint = 0;


    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _secondsBetweenSpawn)
        {
            _elapsedTime = 0;

            Instantiate(_enemyTemplate, _spawnPoints[_currentPoint]);

            _currentPoint++;

            if(_currentPoint > _spawnPoints.Length - 1)
            {
                _currentPoint = 0;
            }
        }
    }
}
