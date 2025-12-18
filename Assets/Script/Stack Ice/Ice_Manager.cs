using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Manager : MonoBehaviour
{

    public float speed;

    [HideInInspector] public Vector2 dir;


    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
