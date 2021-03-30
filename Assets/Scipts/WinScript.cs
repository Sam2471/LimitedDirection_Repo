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
    public AudioClip winaudio;

    public void Start()
    {
        playedwin = false;
        loadingcanvas.SetActive(false);
        wincanvas.SetActive(false);
    }

    // Waiting for win text to finish
    public void Update()
    {
        if (playedwin == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    // Win trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb2.constraints = RigidbodyConstraints2D.FreezeAll;
        wincanvas.SetActive(true);
        winsource.PlayOneShot(winaudio);

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
}

