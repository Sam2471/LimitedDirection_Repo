using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingplatwait : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startpos;
    Vector3 nextpos;

    public bool isonmovingplatform = false;
    public GameObject playertwo;


    void Start()
    {
        nextpos = startpos.position;
    }


    void Update()
    {
        if (isonmovingplatform == true)
        {
            if (transform.position == pos1.position)
            {
                nextpos = pos2.position;
            }
            if (transform.position == pos2.position)
            {
                nextpos = pos1.position;
            }
            playertwo.transform.SetParent(this.transform);
        }
        else
        {
            playertwo.transform.SetParent(null);
        }

        

        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isonmovingplatform = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isonmovingplatform = false;
        }
    }
}
