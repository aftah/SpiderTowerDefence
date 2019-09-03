using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] float waveSpawnTime=5;
    [SerializeField] private int enemyCount;
    [SerializeField] private float timeToWait;
    [SerializeField] private bool stopSpawning = false;


    private void Start()
    {
        if(!stopSpawning)
           InvokeRepeating("WaveSpawn",waveSpawnTime, waveSpawnTime);   
    }

    IEnumerator EnemyDrop()
    {
       
        
        for (int i = 0; i < enemyCount; i++)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeToWait); 
        }
    }

    void WaveSpawn()
    {
        StartCoroutine(EnemyDrop());
    }
}
