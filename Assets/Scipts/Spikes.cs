using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public Transform playerprefab;
    public GameObject playerthird;
    public GameObject respawn;

    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("poooooooooop");
            Destroy(playerthird);
            Instantiate(playerprefab, respawn.transform);
        }
       
    }
    

    void Update()
    {
        if (playerthird == null)
        {
            playerthird = GameObject.Find("Player");           
        }

        if (playerprefab == null)
        {
            
        }


    }
}
