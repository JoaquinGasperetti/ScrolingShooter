using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public float spawnRate = 2f;
    public float spawnDistance = 20f;
    public float spread = 10f;

    private float timer;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnEnemy();
            timer = 1f / spawnRate;
        }
    }

    void SpawnEnemy()
    {
        if (player == null) return;

        
        Vector3 forward = player.forward;
        Vector3 spawnPos = player.position + forward * spawnDistance;

        
        spawnPos += new Vector3(Random.Range(-spread, spread), 0, Random.Range(-spread, spread));

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
