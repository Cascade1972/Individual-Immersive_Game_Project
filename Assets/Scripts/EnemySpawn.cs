/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public int maxEnemies = 4;      // Maximum number of enemies to spawn
    public int enemiesPerWave = 4;   // Number of enemies to spawn per wave
    public float timeBetweenWaves = 5f;  // Time delay between waves
    private int totalWaves = 5;       // Total number of waves

    private int enemiesSpawned = 0;
    private int currentWave = 0;

    void Start()
    {
        SpawnWave();
        //enemiesPerWave = 4;
    }

    void Update()
    {
        // Check if all enemies in the current wave are killed
        if (enemiesSpawned <= enemiesPerWave)
        {
            // Reset counter, start a new wave after a delay, and check for the end of the game
            currentWave++;
            if (currentWave <= totalWaves)
            {
                Invoke("SpawnWave", timeBetweenWaves);
                enemiesSpawned = 0;
            }
        }
    }

    void SpawnWave()
    {
        // Spawn enemies until reaching the maximum number
        for (int i = 0; i < enemiesPerWave && enemiesSpawned < maxEnemies; i++)
        {
            SpawnEnemy();
            enemiesSpawned++;
        }
        enemiesPerWave++;
    }

    void SpawnEnemy()
    {
        // Instantiate the enemy at the specified spawn point
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public int maxEnemies = 4;      // Maximum number of enemies to spawn
    public int enemiesPerWave = 4;   // Number of enemies to spawn per wave
    public float timeBetweenWaves = 5f;  // Time delay between waves
    private int totalWaves = 6;       // Total number of waves

    private int enemiesSpawned = 0;
    private int currentWave = 0;
    private bool spawning = false;

    void Start()
    {
        InvokeRepeating("SpawnWave", 0f, timeBetweenWaves);
    }

    void Update()
    {
        // Check if all enemies in the current wave are killed
        if (currentWave <= totalWaves && enemiesSpawned <= maxEnemies)
        {
            CancelInvoke("SpawnWave");
        }
    }

    void SpawnWave()
    {
        if (!spawning)
        {
            StartCoroutine(SpawnEnemies());
        }
    }

    IEnumerator SpawnEnemies()
    {
        spawning = true;
        for (int i = 0; i < enemiesPerWave && enemiesSpawned < maxEnemies; i++)
        {
            SpawnEnemy();
            enemiesSpawned++;
            yield return new WaitForSeconds(20f); // Delay between each enemy spawn
        }
        currentWave++;
        spawning = false;
    }

    void SpawnEnemy()
    {
        // Instantiate the enemy at the specified spawn point
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public void EnemyDefeated()
    {
        enemiesSpawned--;
    }

}




