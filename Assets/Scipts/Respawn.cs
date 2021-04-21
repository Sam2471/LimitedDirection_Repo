using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Respawn : MonoBehaviour
{
    public GameObject player;
    public AudioSource respawnsource;
    public AudioClip hurtaudio;

    public Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == ("Player"))
        {
            respawnsource.PlayOneShot(hurtaudio);
            SceneManager.LoadScene(scene.name);
            
        }
        
        
    }
    void Update()
    {
        
        if (Input.GetButtonDown("Respwan"))
        {
            respawnsource.PlayOneShot(hurtaudio);
            SceneManager.LoadScene(scene.name);

        }
    }
}
