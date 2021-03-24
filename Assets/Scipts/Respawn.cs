using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject player;

    public Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            SceneManager.LoadScene(scene.name);
        }
        
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Respwan"))
        {
            SceneManager.LoadScene(scene.name);
        }
    }
}
