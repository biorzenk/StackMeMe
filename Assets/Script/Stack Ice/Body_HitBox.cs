using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Body_HitBox : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("Player")) return;

        Debug.Log("Cham than - chet");

        col.gameObject
           .GetComponent<Player_Movement>()
           .Deaded();
    }
}
