using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject Statistique, MainMenu, Gym;

    public void Click_StatsMenu()
    {

        if(Statistique.activeSelf == true)
            Statistique.SetActive(false);
        else
            Statistique.SetActive(true);

    }
    public void Click_StartButton()
    {
        Gym.SetActive(true);
        MainMenu.SetActive(false);

    }
    public void Click_QuitButton()
    {
        Application.Quit();
    }

}
