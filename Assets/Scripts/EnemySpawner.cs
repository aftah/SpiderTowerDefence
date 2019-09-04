using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] float waveSpawnTime=5;
   
    [SerializeField] private int enemyCount;
    [SerializeField] private float timeToWait;
    [SerializeField] private bool stopSpawning = false;

    private List<GameObject> listEnemy;

    private void Start()
    {
        
        //listEnemy = new List<GameObject>(); 
        if(!stopSpawning)
           InvokeRepeating("WaveSpawn",waveSpawnTime, waveSpawnTime);

        //liste Enemy

        //for (int i = 0; i < enemyCount; i++)
        //{
        //    GameObject obj = Instantiate(enemy, transform.position, Quaternion.identity);
        //    listEnemy.Add(obj);  
        //    listEnemy[i].SetActive(false); 
        //}
    }

    private void Update()
    {
            
    }

    IEnumerator EnemyDrop()
    {
       
        
        for (int i = 0; i < enemyCount; i++)
        {

            Instantiate(enemy,transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeToWait); 
        }
    }

    void WaveSpawn()
    {
        StartCoroutine(EnemyDrop());
    }
}
