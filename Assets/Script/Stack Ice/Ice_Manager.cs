using UnityEngine;

public class Ice_Manager : MonoBehaviour
{
    public Polling_Ice pool;
    int direction;
    public float speed = 3f;


    public float stopDuration = 2f;
    float stopTimer = 0f;

    Rigidbody2D rb;
    public bool stopped = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        // FIX RƠI XUỐNG
        rb.gravityScale = 0;
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.freezeRotation = true;
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;
    }

    void Update()
    {
        if (stopped)
        {
            stopTimer += Time.deltaTime;
            if (stopTimer >= stopDuration)
            {
                pool.ReturnBlock(this.gameObject);
            }
            return;
        }

        Vector2 nextPos  = rb.position + Vector2.right * direction * speed * Time.deltaTime;

        rb.MovePosition(nextPos);

        if(rb.position.x < -65f || rb.position.x > 70f)
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


    public void StopBlock()
    {
        stopped = true;
        stopTimer = 0f;
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Static; 
    }
}
