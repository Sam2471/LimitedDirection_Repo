using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PermanentUI : MonoBehaviour
{
    public int gem = 0;
    public Text gemText;
    public float gemsave1;
    public float gemsave2;
    public float gemsave3;

    public Scene scene3;
    public static PermanentUI perm;

    private void Start()
    {
        scene3 = SceneManager.GetActiveScene();
        
        if (!perm)
            perm = this;

        else
            Destroy(gameObject);
    }

    void Update()
    {
        gemsave1 = PlayerPrefs.GetFloat("gemsave1");
        gemsave2 = PlayerPrefs.GetFloat("gemsave2");
        gemsave3 = PlayerPrefs.GetFloat("gemsave3");
        if (scene3.name == "Scene01")
        {
            PlayerPrefs.SetFloat("gemsave1", gem);
        }
        if (scene3.name == "Scene02")
        {
            PlayerPrefs.SetFloat("gemsave2", gem);
        }
        
        if (scene3.name == "Scene03")
        {
            PlayerPrefs.SetFloat("gemsave3", gem);
        }
    }

    public void Reset()
    {
        gem = 0;
        gemText.text = gem.ToString();      
    }


}

