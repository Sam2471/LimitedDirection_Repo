using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musictrigger : MonoBehaviour
{
    public Respawn music;
    public AudioSource startmusic;
    public AudioSource intro;
    // Start is called before the first frame update
    void Start()
    {

        intro.Play();
    }
    public void Update()
    {
        if (music.canplaymusic == false)
        {
            startmusic.Stop();
            intro.Stop();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        intro.Stop();
        startmusic.Play();
    }
}
