using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinScript : MonoBehaviour
{
    public bool playedwin = false;
    public Rigidbody2D rb2;
    public GameObject loadingcanvas;
    public GameObject wincanvas;
    public AudioSource winsource;
    public AudioSource gemsource2;
    public AudioClip winaudio;
    public AudioClip gemclip2;

    public float newsceneonetime;
    public float newscenetwotime;
    public float newscenethreetime;

    public Scene scenewin;

    public float a = 130f;
    public float b = 130f;
    public float c = 145f;

    public void Start()
    {
        GameObject.Find("Timer").GetComponent<Timer>().sceneonetime = newsceneonetime;
        GameObject.Find("Timer").GetComponent<Timer>().scenetwotime = newscenetwotime;
        GameObject.Find("Timer").GetComponent<Timer>().scenethreetime = newscenethreetime;
        playedwin = false;
        loadingcanvas.SetActive(false);
        wincanvas.SetActive(false);
        scenewin = SceneManager.GetActiveScene();
    }

    // Waiting for win text to finish
    public void Update()
    {
        if (playedwin == true)
        {
            if (scenewin.name == "Scene03")
            {
                SceneManager.LoadScene("Main Menu01");            
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (playedwin == true ) 
        {
        
        }
    }
    // Win trigger
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        rb2.constraints = RigidbodyConstraints2D.FreezeAll;
        wincanvas.SetActive(true);
        winsource.PlayOneShot(winaudio);
        Timer.pausetimer = true;
        gemcheck();
        if (collision.gameObject.tag == ("Player"))
        {
            StartCoroutine(playwin());                  
        }
    }
    // Delay before moving on to next scene
    IEnumerator playwin()
    {      
        yield return new WaitForSeconds(3);
        wincanvas.SetActive(false);
        loadingcanvas.SetActive(true);
        yield return new WaitForSeconds(1);
        playedwin = true;     
    }

    IEnumerator sounddeley()
    {        
        yield return new WaitForSeconds(2);
        PermanentUI.perm.gem += 1;
        gemsource2.PlayOneShot(gemclip2);
        PermanentUI.perm.gemText.text = PermanentUI.perm.gem.ToString() + "/5";
    }
    public void gemcheck() 
    {
        if (scenewin.name == "Scene01")
        {
            if (newsceneonetime <= a)
            {
                StartCoroutine(sounddeley());              
            }
        }
        if (scenewin.name == "Scene02")
        {
            if (newscenetwotime <= b)
            {
                StartCoroutine(sounddeley());
            }
        }
        if (scenewin.name == "Scene03")
        {
            if (newscenethreetime <= c)
            {
                StartCoroutine(sounddeley());
            }
        }
    }
}

