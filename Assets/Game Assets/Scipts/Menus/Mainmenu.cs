using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public GameObject Mainbuttons;
    public GameObject Levelselect;
    public GameObject Controlback;
    public GameObject Background2;

    //Play and Quit
    public void PlayGame()
    {
        //Debug.Log("loolj");
        SceneManager.LoadScene("Scene01");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    //Back
    public void Backbutton()
    {
        Background2.SetActive(false);
        Mainbuttons.SetActive(true);
        Controlback.SetActive(false);
        Levelselect.SetActive(false);
    }

    //Controls
    public void Controls()
    {
        Background2.SetActive(true);
        Controlback.SetActive(true);
        Mainbuttons.SetActive(false);
    }

    //Level Select
    public void LevelSelect()
    {
        Controlback.SetActive(true);
        Levelselect.SetActive(true);
        Mainbuttons.SetActive(false);
    }
    public void Levelone()
    {  
        SceneManager.LoadScene("Scene01");
    }
    public void Leveltwo()
    {       
        SceneManager.LoadScene("Scene02");
    }
    public void Levelthree()
    {      
        SceneManager.LoadScene("Scene03");
    }
}
