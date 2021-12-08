using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OeuvreManager : MonoBehaviour
{
    public Text affichageCompteur;
    private int oeuvreCompteur = 0;

    public void AddOeuvre(Oeuvre oeuvre)
    {
        oeuvreCompteur = +1;
        affichageCompteur.text = "Oeuvres sauvez : " + oeuvreCompteur.ToString("00");
    }

}
