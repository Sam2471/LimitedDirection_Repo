using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathscript : MonoBehaviour
{
    public GameObject gemdisable;
    public Scene scene;
    public void Start()
    {
        scene = SceneManager.GetActiveScene();
        gemdisable.SetActive(false);
    }
    void Update()
    {
        if (Input.GetButtonDown("E"))
        {
            SceneManager.LoadScene(scene.name);
        }
        if (Input.GetButtonDown("Q"))
        {
            Application.Quit();
        }
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(scene.name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
