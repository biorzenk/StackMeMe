using UnityEngine;

public class Top_Hitbox : MonoBehaviour
{
    Ice_Manager ice;

    private void Awake()
    {
        ice = transform.parent.GetComponent<Ice_Manager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        foreach (var contact in collision.contacts)
        {
            if (contact.normal.y < -0.5f)
            {
                Debug.Log("Dung tren bang");
                ice.StopBlock();
                return;
            }
        }
    }
}
