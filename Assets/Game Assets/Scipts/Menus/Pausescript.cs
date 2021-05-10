using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausescript : MonoBehaviour
{
    public static bool Ispaused = false;
    public GameObject Pausemenu;
    public GameObject ControlUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Ispaused)
            {
                Resume();
            }
            else
            {
                Pause();           
            }      
        }
    }

    public void Resume() 
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
        Ispaused = false;
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("Main Menu01");
    }
    public void Controls()
    {        
        ControlUI.SetActive(true);
        Pausemenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Backbutton()
    {
        ControlUI.SetActive(false);
        Pausemenu.SetActive(true);
    }
    void Pause()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        Ispaused = true;
    }
}
