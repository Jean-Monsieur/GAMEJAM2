using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject Apart, PersistentUI, Statistique, MainMenu, Gym, calendrier, courir, danse, biblio, travailler;

    


    public void Click_StatsMenu()
    {

        if(Statistique.activeSelf == true)
            Statistique.SetActive(false);
        else
            Statistique.SetActive(true);

    }
    public void Click_StartButton()
    {
        Apart.SetActive(true);
        //PersistentUI.SetActive(true);
        MainMenu.SetActive(false);

    }
    public void Click_Continue()
    {
        calendrier.SetActive(true);
        PersistentUI.SetActive(true);
        Apart.SetActive(false);


    }

    public void Click_QuitButton()
    {
        Application.Quit();
    }

    public void Click_Gym()
    {
        calendrier.SetActive(false);
        Gym.SetActive(true);
        
    }
    public void Click_Danse()
    {
        calendrier.SetActive(false);
        danse.SetActive(true);
        StartCoroutine(TexteGrossis(danse));
        this.gameObject.GetComponent<GameMaster>().setDance(5);

    }
    public void Click_Biblio()
    {
        calendrier.SetActive(false);
        biblio.SetActive(true);
        StartCoroutine(TexteGrossis(biblio));
        this.gameObject.GetComponent<GameMaster>().setIntel(5);

    }
    public void Click_Course()
    {
        calendrier.SetActive(false);
        courir.SetActive(true);
        StartCoroutine(TexteGrossis(courir));
        this.gameObject.GetComponent<GameMaster>().setCardio(5);

    }

    public void Click_Travailler()
    {
        calendrier.SetActive(false);
        Gym.SetActive(true);

    }

    


    IEnumerator TexteGrossis(GameObject Endroit )
    {
        Endroit.transform.GetChild(0).GetChild(0).gameObject.transform.localScale = new Vector3(0F, 01F, 0F);
        for (int i = 0; i < 45; i++)
        {
            Endroit.transform.GetChild(0).GetChild(0).gameObject.transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
            yield return new WaitForSeconds(0.02f);

        }

        yield return new WaitForSeconds(2.0f);

        Endroit.SetActive(false);
        calendrier.SetActive(true);
        this.gameObject.GetComponent<GameMaster>().setJour(1);

    }
}
