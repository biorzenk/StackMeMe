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
        if (!collision.gameObject.CompareTag("CheckIce")) return;
        Ice_Manager otherIce = collision.gameObject.GetComponentInParent<Ice_Manager>();

        foreach (var contact in collision.contacts)
        {
            if (contact.normal.y < -0.5f)
            {
                Debug.Log("Dung tren bang");
                return;
            }
        }
        if (otherIce != null && otherIce.stopped)
        {
            ice.StopBlock(); 
        }
    }
}
