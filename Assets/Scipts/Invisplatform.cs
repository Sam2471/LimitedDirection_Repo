using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisplatform : MonoBehaviour
{
    [SerializeField] private Animator animplat;
    public SpriteRenderer transpancy;

    private enum State { idle, fadeout, fadein }
    State state = State.idle;

    private void Start()
    {
        animplat = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {     
        state = State.fadeout;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        state = State.fadein;
        waitthree(); 
    }

    IEnumerator waitthree()
    {
        state = State.idle;
        yield return new WaitForSeconds(2);
    }

    private void Update()
    {
        if (state == State.fadein || state == State.fadeout)
        {
            //bongoes
            
        }
        else
        {
              state = State.idle;
        }

        animplat.SetInteger("state", (int)state);
    }
}
