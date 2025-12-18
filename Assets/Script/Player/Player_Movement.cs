using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float Jump_force;

    public Transform Ground_check;
    public LayerMask Ground_layer;

    bool _isGrounded;
    bool previousGrounded;
    bool justLanded;

    Animator _animator;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();          
    }

    private void Update()
    {
        previousGrounded = _isGrounded;

        _isGrounded = Physics2D.OverlapCircle(Ground_check.position, 2.5f, Ground_layer);

        Debug.Log("Is Grounded: " + _isGrounded);

        if (_isGrounded && !previousGrounded)
        {
            justLanded = true;
        }

        CharacterJump();
        CheckFall();
        CheckLanding();
    }

    void CharacterJump()
    {
        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, Jump_force);
            rb.interpolation = RigidbodyInterpolation2D.Interpolate; 
            _animator.SetTrigger("isJumpping");
        }
    }

    void CheckFall()
    {
        if (!_isGrounded && rb.velocity.y < 0)
        {
            _animator.SetBool("isFalling", true);
        }
        else
        {
            rb.gravityScale = 2f;
            _animator.SetBool("isFalling", false);
        }
    }

    void CheckLanding()
    {
        if (justLanded)
        {
            _animator.SetTrigger("Landing");
            justLanded = false;
        }
    }

    public void Deaded()
    {
        _animator.SetBool("isDead", true);
    }
}
