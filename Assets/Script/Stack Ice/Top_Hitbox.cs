using UnityEngine;

public class Top_Hitbox : MonoBehaviour
{
    Ice_Manager ice;

    private void Awake()
    {
        ice = GetComponentInParent<Ice_Manager>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.gameObject.CompareTag("Player")) return;

        Debug.Log("Dung tren bang");
        ice.StopBlock();
    }
}
