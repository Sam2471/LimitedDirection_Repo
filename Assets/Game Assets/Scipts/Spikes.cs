using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    public Transform playerprefab;
    public GameObject playerthird;
    public GameObject respawn;

    public AudioSource spikedeath;

    public Scene spikescene;
    void Start()
    {
        spikescene = SceneManager.GetActiveScene();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Debug.Log("poooooooooop");
            SceneManager.LoadScene(spikescene.name);
            //Destroy(playerthird);
            //Instantiate(playerprefab, respawn.transform);
        }
       
    }
    

    void Update()
    {


    }
}
