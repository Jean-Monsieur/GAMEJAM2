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

    [SerializeField]
    public GameObject VM, Baru, Bistro, Dag, Calendrier;

    string[] Jours = new string[7];

    string bar;

    void Start()
    {
        Jours[0] = "Lundi";
        Jours[1] = "Mardi";
        Jours[2] = "Mercredi";
        Jours[3] = "Jeudi";
        Jours[4] = "Vendredi";
        Jours[5] = "Vendredi Soir";
        Jours[6] = "Dimanche";

        jour.text = "Lundi";
        bar = this.GetComponent<CurrentBarScript>().getBarString();
        
       
    }

    
    void Update()
    {
        
        if (Jour == 5)
        {
            Calendrier.SetActive(false);
            switch (bar)
            {
                case "VM":
                    VM.SetActive(true);
                    break;
                case "DAG":
                    Dag.SetActive(true);
                    break;
                case "BARU":
                    Bistro.SetActive(true);
                    break;
                case "BISS":
                    Bistro.SetActive(true);
                    break;
            }

        }
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
