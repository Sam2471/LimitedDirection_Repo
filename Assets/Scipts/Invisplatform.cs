using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisplatform : MonoBehaviour
{
    public SpriteRenderer transpancy;
    private enum State {idle, fadein, fadeout}
    State state = State.idle;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        state = State.fadeout;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        state = State.fadein;
    }
   
    private void Update()
    {
        if (state == State.fadein | state == State.fadeout)
        {

        }
        else
        {
            state = State.idle;
        }
    }
}
