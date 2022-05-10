using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;//BU SINIF
public class RedDragonSpawner : BaseSpawner
{
    //[Range(1, 6)] [SerializeField] float _minSpawnTime;//spawn edilecek objenin minimum süresi
    //[Range(2, 6)] [SerializeField] float _maxSpawnTime;//spawn edilecek objenin maksimum süresi
    //float _randomSpawnTimer, _currentTime;
    [SerializeField] EnemyController _treeEnemy;//Prefabı çağırmak için bunu oluşturduk.
                                                //dizi olusturduk ve inspectordan atadik prefablari yani elimizden geldigince inspectorda
                                                //cözebildigimiz seyleri inspectorda halletmeye calisiyoruz

    //Bu sayede sadece inspectorunde enemycontroller olan bir object atmamizi isteyecek.
    //enemyController iceren dosyalarin gelmesini istedigimiz icin GameObject yazmadik
    //gameObject yazsaydim icine kamera bile atilabilirdi.


    //private void Start()
    //{
    //    //ResetTime();
    //    
    //    }
    //private void Update()
    //{
    //    //_currentTime += Time.deltaTime;//kronometre yapmis olduk.
    //    //if (_currentTime > _randomSpawnTimer)
    //    //{
    //    //    obje instatiate et!
    //    //    EnemySpawner();
    //    //    ResetTime();
    //    //}
    //}

    //private void ResetTime()
    //{
    //    //_currentTime = 0;
    //    //_randomSpawnTimer = UnityEngine.Random.Range(_minSpawnTime, _maxSpawnTime);
    //      yukarıda system classi varsa random yaparken altına unityengine yazmak lazım!
    //      unityengine ve system classlarinin ikisinde de random oldugu icin hata verir.
    //
    //}

    protected override void EnemySpawner()
    {
        Instantiate(_treeEnemy, transform.position,/*this. yazabilirdik.*/transform.rotation, this.transform);
        //ctrl bosluk kod yazarken yanlis yazdiginda düzeltmek icin ise yariyor.
    }
}
