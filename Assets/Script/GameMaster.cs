using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    [SerializeField]
    public Text jour, intel, cardio, strenght, dance;

    private int Jour, Intel, Cardio, Strenght, Dance;

    //private string[] Jours = new Jours[] ;

    string[] Jours = new string[7];

    void Start()
    {
        Jours[0] = "Lundi";
        Jours[1] = "Mardi";
        Jours[2] = "Mercredi";
        Jours[3] = "Jeudi";
        Jours[4] = "Vendredi";
        Jours[5] = "Samedi";
        Jours[6] = "Dimanche";

        jour.text = "Lundi";

        //Week = 2;
        //week.text = Week.ToString();

    }

    
    void Update()
    {
        
    }

    public void setStrenght(int _strenght)
    {
        Strenght = Strenght + _strenght;
        strenght.text = Strenght.ToString();

    }

    public void setIntel(int _intel)
    {
        Intel = Intel + _intel;
        intel.text = Intel.ToString();

    }

    public void setDance(int _dance)
    {
        Dance = Dance + _dance;
        dance.text = Dance.ToString();

    }

    public void setCardio(int _cardio)
    {
        Cardio = Cardio + _cardio;
        cardio.text = Cardio.ToString();

    }


    public void setJour(int _jour)
    {
        Jour += _jour;
        jour.text = Jours[Jour];

    }
}
