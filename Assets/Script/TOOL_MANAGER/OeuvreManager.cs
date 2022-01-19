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
    public string Actualscene;

    public GameObject lIGHT;


    public void AddOeuvre()
    {
        oeuvreCompteur = oeuvreCompteur + 1;
        affichageCompteur.text = "Oeuvres sauvées : " + oeuvreCompteur.ToString("00");

        if(oeuvreCompteur >= 3)
        {
            if (Actualscene == "1")
            {
                textVictoire.text = "Dirigez vous vers la prochaine salle";
                open = true;
                lIGHT.gameObject.SetActive(true);
            }
        }
        if (oeuvreCompteur >= 4)
        {
            textVictoire.text = "Fin de l'alpha Vous avez sauvé toutes les oeuvres";
            open = true;
        }
    }

}
