using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onmouseover : MonoBehaviour
{
    [SerializeField]private GameObject placeholder;
    public GameObject gemicon;
    public GameObject gemtext;

    private void Start()
    {
        placeholder.SetActive(false);
    }

    public void OnMouseOver()
    {
        placeholder.SetActive(true);
        gemicon.SetActive(true);      
    }

    public void OnMouseExit()
    {
        placeholder.SetActive(false);
        gemicon.SetActive(false);
    }
}
