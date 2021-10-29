using UnityEngine;

public sealed class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemiesTemplates;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondBetweenSpawn;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initialize(_enemiesTemplates);
    }

    private void Update()
    {
        SetRealSeconds();

        if(_elapsedTime >= _secondBetweenSpawn)
        {
            SpawnEnemy();
        }
    }
   
    private void SpawnEnemy()
    {
        if (TryGetObject(out GameObject enemies))
        {
            ResetTime();

            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            SetEnemy(enemies, _spawnPoints[spawnPointNumber].position);
        }
    }

    private void SetRealSeconds()
    {
        _elapsedTime += Time.deltaTime;
    }

    private void ResetTime()
    {
        _elapsedTime = 0;
    }

    private void SetEnemy(GameObject enemies, Vector3 spawnPoint)
    {
        enemies.SetActive(true);
        enemies.transform.position = spawnPoint;
    }
}
