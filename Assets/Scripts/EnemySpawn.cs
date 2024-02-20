using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public int maxEnemies = 10;      // Maximum number of enemies to spawn
    public int enemiesPerWave = 5;   // Number of enemies to spawn per wave
    public float timeBetweenWaves = 5f;  // Time delay between waves
    public int totalWaves = 5;       // Total number of waves

    private int enemiesSpawned = 0;
    private int currentWave = 0;

    void Start()
    {
        SpawnWave();
    }

    void Update()
    {
        // Check if all enemies in the current wave are killed
        if (enemiesSpawned >= enemiesPerWave)
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
    }

    void SpawnEnemy()
    {
        // Instantiate the enemy at the specified spawn point
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
