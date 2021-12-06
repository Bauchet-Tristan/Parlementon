using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_UI : MonoBehaviour
{

    public bool UiIsHide = false;


    public void Hide()
    {
        if (UiIsHide == false)
        {
            transform.LeanMoveLocal(new Vector2(-0, -600), 0.5f);
            UiIsHide = true;
        }
        else
        {
            transform.LeanMoveLocal(new Vector2(-0, -339), 0.5f);
            UiIsHide = false;
        }
    }
}
