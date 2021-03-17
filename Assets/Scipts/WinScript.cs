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

    public void Start()
    {
        playedwin = false;
        //loadingcanvas.SetActive(false);
        wincanvas.SetActive(false);
    }

    public void Update()
    {
        if (playedwin == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb2.constraints = RigidbodyConstraints2D.FreezeAll;
        wincanvas.SetActive(true);

        if (collision.gameObject.tag == ("Player"))
        {
            StartCoroutine(playwin());  
        }
    }

    IEnumerator playwin()
    {      
        yield return new WaitForSeconds(3);
        wincanvas.SetActive(false);
        loadingcanvas.SetActive(true);
        yield return new WaitForSeconds(1);
        playedwin = true;     
    }
}

