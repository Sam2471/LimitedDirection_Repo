using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplats : MonoBehaviour
{
    public Rigidbody2D rbplat;

    void Start()
    {
        StartCoroutine()
        rbplat.velocity = new Vector2(-10, rbplat.velocity.y);
    }

    IEnumerator plattimer()
    {

    }
    
}
