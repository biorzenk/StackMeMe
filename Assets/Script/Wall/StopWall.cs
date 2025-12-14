using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWall : MonoBehaviour
{
    public float speed = 2f;
    private bool isStopped = false;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(!isStopped)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (transform.position.x > 10f)
        {
           gameObject.SetActive(false);
        }
    }

    private void StopMoving()
    {
        isStopped = true;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            StopMoving();
        }
    }

    private void OnEnable()
    {
        isStopped = false;
    }
}
