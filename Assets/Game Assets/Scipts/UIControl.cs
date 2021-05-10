using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    public Animator anim7;

    public bool isfading = false;
    //UI Timer Not Active
    void Start()
    {
        StartCoroutine(waitthree());
        anim2.SetBool("canfade", false);
        anim3.SetBool("canfade", false);
        anim4.SetBool("canfade", false);
        anim5.SetBool("canfade", false);
        anim6.SetBool("canfade", false);
        anim7.SetBool("canfade", false);
    }
    //UI Timer Active
    IEnumerator waitthree()

    {
        yield return new WaitForSeconds(5);
        anim2.SetBool("canfade", true);
        anim3.SetBool("canfade", true);
        anim4.SetBool("canfade", true);
        anim5.SetBool("canfade", true);
        anim6.SetBool("canfade", true);
        anim7.SetBool("canfade", true);
        isfading = true;
    }
}
