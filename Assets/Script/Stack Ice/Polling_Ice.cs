using System.Collections.Generic;
using UnityEngine;

public class Polling_Ice : MonoBehaviour
{
    public GameObject Ice;
    public Transform leftPoint;
    public Transform rightPoint;

    public int blocksPerRow = 6;
    public int poolSize = 30;
    public float spawnDelay = 1.5f;

    Queue<GameObject> pool = new Queue<GameObject>();

    float blockW;
    float timer;
    bool spawnFromLeft = true;

    void Awake()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject ice = Instantiate(Ice);
            ice.SetActive(false);
            pool.Enqueue(ice);
        }
    }

    void Start()
    {
        SpriteRenderer sr =
            pool.Peek().GetComponentInChildren<SpriteRenderer>();
        blockW = sr.bounds.size.x;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnDelay)
        {
            SpawnRow();
            spawnFromLeft = !spawnFromLeft; // đổi bên
            timer = 0f;
        }
    }

    void SpawnRow()
    {
        Vector2 dir = spawnFromLeft ? Vector2.right : Vector2.left;
        Vector3 startPos = spawnFromLeft
            ? leftPoint.position
            : rightPoint.position;

        GameObject last = null;

        for (int i = 0; i < blocksPerRow; i++)
        {
            GameObject ice = GetIce();
            ice.SetActive(true);

            Ice_Manager move = ice.GetComponent<Ice_Manager>();
            if (move != null) move.dir = dir;

            if (i == 0)
                ice.transform.position = startPos;
            else
                ice.transform.position =
                    last.transform.position + (Vector3)(dir * blockW);

            last = ice;
        }
    }

    GameObject GetIce()
    {
        GameObject ice = pool.Dequeue();
        pool.Enqueue(ice);
        return ice;
    }
}
