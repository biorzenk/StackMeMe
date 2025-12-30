using UnityEngine;

public class Body_HitBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        Player_Movement player = other.GetComponentInParent<Player_Movement>();
        if (player != null)
        {
            Debug.Log("Chạm body → chết");
            player.Deaded();
        }
    }
}
