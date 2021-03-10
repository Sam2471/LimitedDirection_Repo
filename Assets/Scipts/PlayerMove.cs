using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Collider2D colid;
    [SerializeField] private LayerMask ground;
    [SerializeField] private Animator anim;


    public bool candd = false;

    private enum State {idle, running, jumping, falling, djump}
    State state = State.idle;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        colid = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float hdirection = (Input.GetAxis("Horizontal"));

        if (hdirection < 0)
        {
            rb.velocity = new Vector2(-10, rb.velocity.y);
            rb.transform.localScale = new Vector3(-1, 1, 1);

        }

        else if (hdirection > 0)
        {
            rb.velocity = new Vector2(10, rb.velocity.y);
            rb.transform.localScale = new Vector3(1, 1, 1);

        }

        if (Input.GetButtonDown("Jump") && colid.IsTouchingLayers(ground))
        {
            rb.velocity = new Vector2(rb.velocity.x, 45f);
            state = State.jumping;
        }

        StateSwitch();
        anim.SetInteger("state", (int)state);
    }

    private void StateSwitch()
    {
        if (state == State.jumping)
        {
            if (rb.velocity.y < .1f)
            {
                state = State.falling;
            }
        }
        else if (state == State.falling)
        {
            if (colid.IsTouchingLayers(ground))
            {
                state = State.idle;
            }
        }
        else if (Mathf.Abs(rb.velocity.x) > 1f)
        {
            state = State.running;
        }

        else
        {
            state = State.idle;
        }
    }
}
