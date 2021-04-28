using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisplatform : MonoBehaviour
{
    [SerializeField]private Animator animplat;
    public SpriteRenderer transpancy;

    private enum State {idle, fadeout, fadein}
    State state = State.idle;

    private void Start()
    {
        animplat = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("poop4");
        state = State.fadeout;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("poop5");
        state = State.fadein;
    }
   
    private void Update()
    {
        if (state == State.fadein || state == State.fadeout)
        {
            // bongoes
            
        }
        else
        {
              state = State.idle;
        }

        animplat.SetInteger("state", (int)state);
    }
}
