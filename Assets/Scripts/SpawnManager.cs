using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    public GameObject powerup;
    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 0.75f;

    private float startDelay = 2.0f;
    private float enemySpawnTime = 10.0f;
    private float powerupSpawnTime = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomEnemy()
    {
        float randomx = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnpos = new Vector3(randomx, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnpos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomx = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomx, ySpawn, randomZ);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
