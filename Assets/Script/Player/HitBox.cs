using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.Experimental;

public class HitBox : MonoBehaviour
{
    public GameObject Trap;

    bool vacham;

    private void OnCollisionEnter2D(Collision2D Trap)
    {
        if(Trap.gameObject.CompareTag("Trap"))
        {
            Player_Movement player = Trap.gameObject.GetComponent<Player_Movement>();
            if (Trap != null)
            {
                vacham = true;
                Debug.Log("Vacham" + vacham);
                player.Deaded();
            }
        }
    }
}
