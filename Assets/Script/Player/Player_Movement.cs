using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] UILevel_Manager uiManager;

    [SerializeField] private float Jump_force;


    public Transform Ground_check;
    public LayerMask Ground_layer;

    bool isLanding = false;
    bool _isGrounded;
    bool previousGrounded;
    bool justLanded;
    bool _isDead;


    Animator _animator;
    Rigidbody2D rb;
    Collider2D playerCollider;

    public Audio_Manager audio_Manager;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        Collider2D col = rb.GetComponent<Collider2D>();
        playerCollider = GetComponentInChildren<Collider2D>();
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;

        if (playerCollider == null)
        {
            Debug.LogError("Player không có Collider2D!");
        }
        rb.gravityScale = 2f;
    }

    private void FixedUpdate()
    {
        previousGrounded = _isGrounded;

        _isGrounded = Physics2D.OverlapCircle(Ground_check.position, 1.88f, Ground_layer);
        Debug.Log(_isGrounded);

        if (_isGrounded && !previousGrounded)
        {
            justLanded = true;
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }

    }


    private void Update()
    {
        if(_isDead) return;
        CharacterJump();
        CheckFall();
        CheckLanding();
    }
    void CharacterJump()
    {
        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            if(_isDead) return ;

            if (!_isDead)
            {
                rb.velocity = new Vector2(rb.velocity.x, Jump_force);
                _animator.SetTrigger("isJumpping");
                Audio_Manager.Instance.PlaySFX(Audio_Manager.Instance._playerJump);

            }
        }
    }

    void CheckFall()
    {
        if (!_isGrounded && rb.velocity.y < -0.1f)
        {
            _animator.SetBool("isFalling", true);
        }
        else
        {
            _animator.SetBool("isFalling", false);
        }
    }

    void CheckLanding()
    {
        if (justLanded)
        {
            if (_isDead) return;
            isLanding = true;
            _animator.SetTrigger("Landing");
            justLanded = false;
            StartCoroutine(LandingDone());
        }
    }

    IEnumerator LandingDone()
    {
        yield return new WaitForSeconds(1);
        _animator.ResetTrigger("Landing");
    }

    public void Deaded()
    {

        if (_isDead) return;

        _isDead = true;
        _animator.SetBool("isDead", true);
        Audio_Manager.Instance.PlaySFX(Audio_Manager.Instance._playerDead);
        if (uiManager != null)
        {
            uiManager.PannelDead();
        }


        if (playerCollider != null)
        {
            playerCollider.enabled = false;
        }


        rb.velocity = Vector2.zero;
        rb.simulated = false;

    }
}