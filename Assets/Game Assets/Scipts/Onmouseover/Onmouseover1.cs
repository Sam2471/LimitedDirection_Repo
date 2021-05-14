using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onmouseover1 : MonoBehaviour
{
    [SerializeField]private GameObject placeholder;
    public GameObject gemicon;
    public GameObject gemtext1;
    public Text text;

    private void Start()
    {
        placeholder.SetActive(false);
        
    }

    public void OnMouseOver()
    {
        placeholder.SetActive(true);
        gemicon.SetActive(true);
        gemtext1.SetActive(true);
        text.text = PermanentUI.perm.gemsave2.ToString() + "/5";
    }

    public void OnMouseExit()
    {
        placeholder.SetActive(false);
        gemicon.SetActive(false);
        gemtext1.SetActive(false);
    }
}
