using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplats : MonoBehaviour
{
    public float left = 500f;
    public float right = -500f;

    public float speedl = -5;
    public float speed2 = 5;

    public bool flip = true;

    public Rigidbody2D rbplat;
    public Vector2 nextpos;
    public Vector2 currentpos;
    public GameObject movableplat; 

    void Start()
    {
        flip = true;

        currentpos = movableplat.transform.position;
        nextpos = new Vector2(10, movableplat.transform.position.y);

        StartCoroutine(plattimer());
    }

    void Update()
    {
        //rbplat.velocity = new Vector2(5, rbplat.velocity.y);
        if (currentpos == nextpos && flip == true)
        {
            movableplat.transform.localScale = new Vector2(-1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        flip = false;
        movableplat.transform.localScale = new Vector2(-1, 1);
    }

    IEnumerator plattimer()
    {
        yield return new WaitForSeconds(0);
    }
    
}
