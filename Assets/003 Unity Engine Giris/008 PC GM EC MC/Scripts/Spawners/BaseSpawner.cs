using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    [Range(1, 6)] [SerializeField] float _minSpawnTime;//spawn edilecek objenin minimum süresi
    [Range(2, 6)] [SerializeField] float _maxSpawnTime;//spawn edilecek objenin maksimum süresi
    float _randomSpawnTimer, _currentTime;

    void Start()
    {
        ResetTime();
    }

    void Update()
    {
        _currentTime += Time.deltaTime;//kronometre yapmis olduk.
        if (_currentTime > _randomSpawnTimer)
        {
            //obje instatiate et!
            EnemySpawner();
            ResetTime();
        }
    }
    private void ResetTime()
    {
        _currentTime = 0;
        _randomSpawnTimer = UnityEngine.Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    protected abstract void EnemySpawner();     //DÝKKAT!!!! ABSTRACT METOT OLUÞTURDUK VE OVERRÝDE ETTÝK!
}
