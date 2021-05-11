using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timertext;

    public float miliseconds, seconds, minutes;

    void Update()
    {
        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);
        miliseconds = (int)(Time.time * 100f);
        timertext.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + miliseconds.ToString("00");
        if (miliseconds >= 99) 
        {
            miliseconds = 0;
                 
        }
        if (seconds >= 59) 
        {
            seconds = 0;
           
        
        }
    }
}
