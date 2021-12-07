using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OeuvreManager : MonoBehaviour
{
    public Text affichageCompteur;
    private int oeuvreCompteur = 0;

    public void start()
    {
        oeuvreCompteur = +1;
        affichageCompteur.text = "didier2";
    }

    public void update()
    {
        oeuvreCompteur = +1;
        affichageCompteur.text = "didier2";
    }

}
