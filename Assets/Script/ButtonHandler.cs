using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject Statistique, MainMenu, Gym, calendrier;

    public void Click_StatsMenu()
    {

        if(Statistique.activeSelf == true)
            Statistique.SetActive(false);
        else
            Statistique.SetActive(true);

    }
    public void Click_StartButton()
    {
        calendrier.SetActive(true);
        MainMenu.SetActive(false);

    }
    public void Click_QuitButton()
    {
        Application.Quit();
    }

    public void Click_Gym()
    {
        calendrier.SetActive(false);
        Gym.SetActive(true);
        Application.Quit();
    }
}
