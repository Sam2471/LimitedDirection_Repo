using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onmouseover : MonoBehaviour
{
    [SerializeField]private GameObject placeholder;

    private void Start()
    {
        placeholder.SetActive(false);
    }

    public void OnMouseOver()
    {
        Debug.Log("poop6");
        placeholder.SetActive(true);
    }

    public void OnMouseExit()
    {
        placeholder.SetActive(false);
    }
}
