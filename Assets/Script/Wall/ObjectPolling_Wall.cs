using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPolling_Wall : MonoBehaviour
{
    public GameObject _wallPrefab;
    [SerializeField] public int _poolSize;

    private Queue<GameObject> pool = new Queue<GameObject>();   


    void Update()
    {

    }

    public GameObject GetWall()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            return Instantiate(_wallPrefab);
        }
    }

    public void ReturnWall(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
