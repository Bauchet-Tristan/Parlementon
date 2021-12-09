using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OeuvreManager : MonoBehaviour
{
    public Text affichageCompteur;
    public Text textVictoire;
    private int oeuvreCompteur = 0;


    public void AddOeuvre()
    {
        oeuvreCompteur = oeuvreCompteur + 1;
        affichageCompteur.text = "Oeuvres sauvez : " + oeuvreCompteur.ToString("00");

        if(oeuvreCompteur >= 3)
        {
            textVictoire.text = "C'est gagnée vous avez sauvé toutes les oeuvres / Fin de l'Alpha";
        }
    }

}
