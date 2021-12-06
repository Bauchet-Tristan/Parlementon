using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Outil : MonoBehaviour
{
    public GameObject hache ;
    public GameObject lance ; 

    public void switch_Hache()
    {
        Unactive_ALL();
        hache.SetActive(false);
    }

    public void switch_Lance()
    {
        Unactive_ALL();
        hache.SetActive(true);
    }

    public void Unactive_ALL()
    {
        hache.SetActive(false);
        lance.SetActive(false);
    }

}
