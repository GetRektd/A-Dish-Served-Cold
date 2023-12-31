using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

     public GameObject enemyPrefab;
     private float spawnRange = 9;
      public int waveNumber = 1;
      public int enemyCount;
      private float xRange = 6;




    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        { 
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn) {
        for (int i = 0; i < enemiesToSpawn; i++){
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);


        }
    }

     private Vector3 GenerateSpawnPosition () 
          {
           
            Vector3 randomPos = new Vector3(Random.Range(-xRange,xRange), 25, 70);
            return randomPos;
           } 

    
}
