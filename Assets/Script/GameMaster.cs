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

    [SerializeField]
    public GameObject audioSource;


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
                    if (Intel >= 5 && Cardio >= 0 && Strenght >= 15 && Dance >= 0)
                    {
                        VM.transform.GetChild(1).GetComponent<GetDialog>().changeDialogue("Dialog1");
                        audioSource.GetComponent<AudioPlayer>().PlayFemaleWin();
                    }
                    else
                    {
                        VM.transform.GetChild(1).GetComponent<GetDialog>().changeDialogue("Dialog2");

                        audioSource.GetComponent<AudioPlayer>().PlayFemaleLoss();

                    }

                    break;
                case "DAG":
                    Dag.SetActive(true);
                    if (Intel >= 0 && Cardio >= 5 && Strenght >= 5 && Dance >= 10)
                    {
                        Dag.transform.GetChild(2).GetComponent<GetDialog>().changeDialogue("Dialog1");
                        audioSource.GetComponent<AudioPlayer>().PlayFemaleWin();

                    }
                    else
                    {
                        Dag.transform.GetChild(2).GetComponent<GetDialog>().changeDialogue("Dialog2");
                        audioSource.GetComponent<AudioPlayer>().PlayFemaleLoss();
                    }



                    break;
                case "BARU":
                    Baru.SetActive(true);
                    if (Intel >= 15 && Cardio >= 0 && Strenght >= 0 && Dance >= 5)
                    {
                        Baru.transform.GetChild(2).GetComponent<GetDialog>().changeDialogue("Dialog1");
                        audioSource.GetComponent<AudioPlayer>().PlayFemaleWin();
                    }

                    else
                    {
                        Baru.transform.GetChild(2).GetComponent<GetDialog>().changeDialogue("Dialog2");
                        audioSource.GetComponent<AudioPlayer>().PlayFemaleLoss();
                    }

                    break;
                case "BISS":
                    Bistro.SetActive(true);
                    if (Intel >= 5 && Cardio >= 10 && Strenght >= 5 && Dance >= 5)
                    {
                        Bistro.transform.GetChild(2).GetComponent<GetDialog>().changeDialogue("Dialog1");
                        audioSource.GetComponent<AudioPlayer>().PlayFemaleWin();
                    }

                    else
                    {
                        Bistro.transform.GetChild(2).GetComponent<GetDialog>().changeDialogue("Dialog2");
                        audioSource.GetComponent<AudioPlayer>().PlayFemaleLoss();

                    }

                    break;
            }
            Jour = 100;
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
        if (Jour == 5)
            Calendrier.SetActive(false);

    }
}
