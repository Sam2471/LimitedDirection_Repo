using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PermanentUI : MonoBehaviour
{
    public int score = 0;
    public int gem = 0;
    public Text gemText;
    public float gemsave;

    public static PermanentUI perm;

    private void Start()
    {
        gemsave = PlayerPrefs.GetFloat("gemsave");

        if (!perm)
            perm = this;

        else
            Destroy(gameObject);
    }

    void Update()
    {
        PlayerPrefs.SetFloat("gemsave", gem);
    }

    public void Reset()
    {
        gem = 0;
        gemText.text = gem.ToString();      
    }


}

