﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveL3 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Collider2D colid;
    [SerializeField] private LayerMask ground;
    [SerializeField] private Animator anim;
    public AudioSource playeraudio;
    public AudioSource gemaudio;
    public AudioClip jumpaudio;
    public AudioClip hurtaudio;
    public AudioClip spikeaudio;

    public int gemcount = 0;
    public AudioClip gemclip;

    public bool candd = false;
    public bool istouch;
    public int pos = 1;
    //FSM
    private enum State {idle, running, jumping, falling, djump}
    State state = State.idle;

    private void Start()
    {
        // Automated conponent stuff
        rb = GetComponent<Rigidbody2D>();
        colid = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        istouch = true;
    }

    private void Update()
    {
        //General Movment 
        float hdirection = (Input.GetAxis("Horizontal"));

        if (hdirection < 0)
        {
            

        }

        else if (hdirection > 0)
        {
            rb.velocity = new Vector2(10, rb.velocity.y);
            rb.transform.localScale = new Vector3(1, 1, 1);

        }
        // Jump
        if (Input.GetButtonDown("Jump") && colid.IsTouchingLayers(ground))
        {
            playeraudio.PlayOneShot(jumpaudio); 
            rb.velocity = new Vector2(rb.velocity.x, 45f);
            state = State.jumping;
            pos = 1;
        }
        
        //Double Jump
        if (Input.GetButtonDown("Jump") && candd == true)
        {
            playeraudio.PlayOneShot(jumpaudio);
            state = State.djump;
            candd = false;
            pos = 2;
            
            rb.velocity = new Vector2(rb.velocity.x, 45f);
                    
        }
                    
        if (state == State.falling && pos == 1)
        {
            candd = true;
            
        }
       
        if (colid.IsTouchingLayers(ground))
        {
            candd = false;
            pos = 1;
        }

        // Other Functions 
        StateSwitch();
        anim.SetInteger("state", (int)state);

        // Check is touching ground
        if (colid.IsTouchingLayers(ground))
        {
            istouch = true;
        }
        else
        {
            istouch = false;
        }
    }

    IEnumerator wait()
    {
        candd = false;
        pos = 1;
        yield return new WaitForSeconds(0); 
    }

    // FSM Switch Anims Process
    private void StateSwitch()
    {
        if (state == State.jumping)
        {
            if (rb.velocity.y < .1f)
            {
                state = State.falling;
                candd = true; 
            }
        }
        else if (state == State.falling)
        {
            if (colid.IsTouchingLayers(ground) && state != State.djump)
            {
                state = State.idle;
            }
        }
        else if (Mathf.Abs(rb.velocity.x) > 1f && state != State.djump && istouch == true)
        {
            state = State.running;
        }

        else if (colid.IsTouchingLayers(ground)) 
        {
            state = State.idle;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectable")
        {
            gemaudio.PlayOneShot(gemclip);
            Destroy(collision.gameObject);
            PermanentUI.perm.gem += 1;
            PermanentUI.perm.gemText.text = PermanentUI.perm.gem.ToString() + "/5";
        }
    }
}