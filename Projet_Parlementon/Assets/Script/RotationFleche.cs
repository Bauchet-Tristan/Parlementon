using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFleche : MonoBehaviour
{

    public Hide_UI link_Hide_UI;

    public void rotation180()
    {
        if (link_Hide_UI.UiIsHide == false)
        {
            LeanTween.rotateZ(gameObject, 180, 0.5f);
        }
        else 
        {
            LeanTween.rotateZ(gameObject, 0, 0.5f);
        }
    }
}
