using System.Collections.Generic;
using UnityEngine;

public class Polling_Ice : MonoBehaviour
{
    public GameObject Ice;

    [SerializeField] int poolSize = 40;
    [SerializeField] int blocksPerRow = 20;
    [SerializeField] float spawnY = 1.66f;

    Queue<GameObject> pool = new Queue<GameObject>();
    bool spawnLeft = true;


    float blockWidth;
    float blockHeight;

    void Awake()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject ice = Instantiate(Ice);
            ice.SetActive(false);
            pool.Enqueue(ice);
        }

        blockWidth = Ice.GetComponent<SpriteRenderer>().bounds.size.x;
        blockHeight = Ice.GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, 1.5f);
    }

    void Spawn()
    {
        float spawnX;
        int dir;

        if (spawnLeft)
        {
            spawnX = -65f;
            dir = 1;
        }
        else
        {
            spawnX = 70f;
            dir = -1;
        }

        float x = spawnX;

        for (int i = 0; i < blocksPerRow; i++)
        {
            if (pool.Count == 0) break;

            GameObject block = pool.Dequeue();
            block.transform.position = new Vector2(x, spawnY);
            block.SetActive(true);

            Ice_Manager ice = block.GetComponent<Ice_Manager>();
            ice.ResetState();
            ice.SetDirection(dir);

            x += blockWidth * dir; 
        }

        if (spawnLeft)
        {
              spawnY += blockHeight;
        }else
        {
            spawnY += blockHeight;
        }
        spawnLeft = !spawnLeft;
    }

    public void ReturnBlock(GameObject block)
    {
        block.SetActive(false);
        pool.Enqueue(block);
    }
}
