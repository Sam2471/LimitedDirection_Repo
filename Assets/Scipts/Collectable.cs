using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int gemcount = 0;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
       if (collision.tag == ("Player"))
       {    
           Destroy(this);
            gemcount + 1;
       }
    }
}
