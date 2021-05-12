using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timertext;
    public float miliseconds, seconds, minutes;
    public float totaltime;
    public static bool pausetimer = false;
    public static Timer tim;
    

    public float sceneonetime;
    public float scenetwotime;
    public float scenethreetime;
    public float resetlad = 0f;

    public Scene scene;

    void Start()
    {     
        pausetimer = false;              
        scene = SceneManager.GetActiveScene();      
        sceneonetime = PlayerPrefs.GetFloat("sceneonetime");      
        scenetwotime = PlayerPrefs.GetFloat("scenetwotime");
        scenethreetime = PlayerPrefs.GetFloat("scenethreetime");     
    }

    void Update()
    {
        if (Input.GetButtonDown("ppreset")) 
        {
            ppreset();     
        }

        if (pausetimer == false) 
        {
            minutes = (int)(Time.timeSinceLevelLoad / 60f) % 60f;
            seconds = (int)(Time.timeSinceLevelLoad % 60f);
            miliseconds = (int)(Time.timeSinceLevelLoad * 100f) % 100;
        }   

        timertext.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + miliseconds.ToString("00");

        if (pausetimer == true)
        {
            totaltime = (minutes * 60) + seconds + (miliseconds / 100);

            if (scene.name == "Scene01")
            {
                sceneonetime = totaltime;                             
                if (totaltime <= sceneonetime)
                {
                    PlayerPrefs.SetFloat("sceneonetime", sceneonetime);
                }
            }
            if (scene.name == "Scene02")
            {
                scenetwotime = totaltime;
                if (totaltime <= sceneonetime)
                {
                    PlayerPrefs.SetFloat("scenetwotime", scenetwotime);
                }
            }
            if (scene.name == "Scene03")
            {
                scenethreetime = totaltime;
                if (totaltime <= sceneonetime)
                {
                    PlayerPrefs.SetFloat("scenethreetime", scenethreetime);
                }
            }                                                                                                         
        }
    }

    public void ppreset()
    {
        Debug.Log("pooop9");
        PlayerPrefs.SetFloat("sceneonetime", resetlad);
        PlayerPrefs.SetFloat("scenetwotime", resetlad);
        PlayerPrefs.SetFloat("scenethreetime", resetlad);
    }
}
