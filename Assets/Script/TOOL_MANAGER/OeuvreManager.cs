using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OeuvreManager : MonoBehaviour
{
    public Text affichageCompteur;
    public Text textVictoire;
    public int oeuvreCompteur = 0;
    public bool open = false;


    public void AddOeuvre()
    {
        oeuvreCompteur = oeuvreCompteur + 1;
        affichageCompteur.text = "Oeuvres sauvées : " + oeuvreCompteur.ToString("00");

        if(oeuvreCompteur >= 3)
        {
            textVictoire.text = "Dirigé vous vers la prochaine salle";
            open = true;
        }
    }

}
