using UnityEngine;

public class Body_HitBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        Rigidbody2D rb = other.attachedRigidbody;
        if (rb == null) return;

        // Nếu player đang rơi hoặc đứng yên → KHÔNG chết
        if (rb.velocity.y <= 0f)
            return;

        // Nếu đang nhảy lên từ dưới → KHÔNG chết
        if (rb.velocity.y > 0.1f)
            return;

        Debug.Log("Cham than bang - chet");
        other.GetComponentInParent<Player_Movement>()?.Deaded();
    }
}
