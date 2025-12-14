using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Move : MonoBehaviour
{
    [Header("Speed")]
    public float speed = 5f;

    public Transform Object;

    void Update()
    {
        Object.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
