using UnityEngine;

public class Ice_Manager : MonoBehaviour
{
    public Polling_Ice pool;
    int direction;
    public float speed = 3f;


    public float stopDuration = 2f;
    float stopTimer = 0f;

    Rigidbody2D rb;
    bool stopped = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        // FIX RƠI XUỐNG
        rb.gravityScale = 0;
        rb.freezeRotation = true;
    }

    void Update()
    {
        if (stopped)
        {
            return;
        }

        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        if(transform.position.x < -25f || transform.position.x > 30f)
        {

            pool.ReturnBlock(this.gameObject);
        }
    }

    public void SetDirection(int dir)
    {
        direction = dir;
    }

    public void ResetState()
    {
        stopped = false;
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.velocity = Vector2.zero;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("Player")) return;

        // Player đứng từ trên xuống
        if (col.contacts[0].normal.y < -0.5f)
        {
            StopBlock(); // thành sàn
        }
        else
        {
            Debug.Log("THUA"); // chạm bên
        }
    }

    void StopBlock()
    {
        stopped = true;
        stopTimer = 0f;
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Static; // đứng không trượt
    }
}
