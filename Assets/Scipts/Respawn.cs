using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Respawn : MonoBehaviour
{
    public GameObject player;
    public AudioSource respawnsource;
    public AudioClip hurtaudio;

    public Scene scene;
    public GameObject deathscreen;
    public Text deathtext;
    string[] quips = new string[8] { "Is this too difficult for you?", "You must have done that on purpose right?", "Great job… At death.", "Noob…", "You suck.", "Just quit.", "...", "Loooooooser." };
    public bool canplaymusic = true;
    public int rng;

    void Start()
    {

        deathscreen.SetActive(false);
        scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == ("Player"))
        {
            System.Random random = new System.Random();
            int usedeath = random.Next(quips.Length);
            string pickquip = quips[usedeath];
            deathtext.text = pickquip;
            respawnsource.PlayOneShot(hurtaudio);
            canplaymusic = false;
            deathscreen.SetActive(true);
            //SceneManager.LoadScene("DeathScene");
        }               
    }
    void Update()
    {
        
        if (Input.GetButtonDown("Respwan"))
        {
            deathscreen.SetActive(true);
            canplaymusic = false;
            respawnsource.PlayOneShot(hurtaudio);
            //SceneManager.LoadScene("DeathScene");
        }
    }
}
