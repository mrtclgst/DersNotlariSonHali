using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;//BU SINIF
public class TreeSpawner : BaseSpawner
{
    [SerializeField] EnemyController[] _treeEnemy;
    //[Range(1,6)][SerializeField]float _minSpawnTime;//spawn edilecek objenin minimum süresi
    //[Range(2,6)][SerializeField]float _maxSpawnTime;//spawn edilecek objenin maksimum süresi
    //float _randomSpawnTimer,_currentTime;
    //[SerializeField] EnemyController[] _treeEnemy;//Prefabı çağırmak için bunu oluşturduk.
    //dizi olusturduk ve inspectordan atadik prefablari yani elimizden geldigince inspectorda
    //cözebildigimiz seyleri inspectorda halletmeye calisiyoruz
    
    //Bu sayede sadece inspectorunde enemycontroller olan bir object atmamizi isteyecek.
    //enemyController iceren dosyalarin gelmesini istedigimiz icin GameObject yazmadik

    //private void Start()
    //{   
    //}
    //private void Update()
    //{
    //    //_currentTime += Time.deltaTime;//kronometre yapmis olduk.
    //    //if (_currentTime>_randomSpawnTimer)
    //    //{
    //    //    //obje instatiate et!
    //    //    EnemySpawner();
    //    //    ResetTime();
    //    //}
    //}
    //private void ResetTime()
    //{
    //    //_currentTime = 0;
    //    //_randomSpawnTimer = UnityEngine.Random.Range(_minSpawnTime, _maxSpawnTime);
    //}
    protected override void EnemySpawner()
    {
        int _randomIndex = Random.Range(0, _treeEnemy.Length);
        Instantiate(_treeEnemy[_randomIndex], transform.position, transform.rotation, this.transform);
    }
}
