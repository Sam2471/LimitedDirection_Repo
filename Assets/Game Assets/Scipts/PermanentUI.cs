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
<<<<<<< HEAD
        gemsave = PlayerPrefs.GetFloat("gemsave");

=======
        scene3 = SceneManager.GetActiveScene();
        
>>>>>>> 3ca8e09885bebd943d0e12394ffae0d5dc40d53f
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

