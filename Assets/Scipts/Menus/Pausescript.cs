using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausescript : MonoBehaviour
{
    public static bool Ispaused  false;
    public gameObject Pausemenu;
    // Update is called once per frame
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

    void Resume() 
    {

    }

    void Pause()
    {

    }
}
