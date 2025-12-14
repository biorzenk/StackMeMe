using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    public ObjectPolling_Wall pool;
    public float spawnInteral = 20  ;

    float timer = 0f;
    float height = 0f;


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInteral)
        {
            SpawnWall();
            timer = 0.5f;
        }
    }

    void SpawnWall()
    {
        GameObject wall = pool.GetWall();
        if (wall == null)
        {
            Debug.LogWarning("Không còn wall trong pool!");
            return;
        }
        wall.transform.position = new Vector2(Random.Range(-3f, 3f), height);
        Debug.Log("Spawn Wall at height: " + wall.transform.position);
        height += 1.5f;
    }
}
