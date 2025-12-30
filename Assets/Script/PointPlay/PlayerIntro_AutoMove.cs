using UnityEngine;

public class PlayerIntro_AutoMove : MonoBehaviour
{
    public Transform pointB;
    public float speed = 2f;

    float fixedY;

    void Start()
    {                                                                    
        fixedY = transform.position.y; 
    }

    void Update()
    {
        if (pointB == null) return;

        float newX = Mathf.MoveTowards(
            transform.position.x,
            pointB.position.x,
            speed * Time.deltaTime
        );

        transform.position = new Vector2(newX, fixedY);

        if (Mathf.Abs(transform.position.x - pointB.position.x) < 0.05f)
        {
            enabled = false; 
        }
    }
}
