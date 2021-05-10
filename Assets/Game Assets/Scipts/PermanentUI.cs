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

    public static PermanentUI perm;

    private void Start()
    {
        

        if (!perm)
            perm = this;

        else
            Destroy(gameObject);

    }

    public void Reset()
    {
        gem = 0;
        gemText.text = gem.ToString();
        //healthAmount.text = health.ToString();
    }


}

