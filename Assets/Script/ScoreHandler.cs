using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    private int points = 0;
    public Text text;
    public Text textSucces;
    public Text textDefaite;
    int Fin;

    [SerializeField]
    private GameObject Menu;
    [SerializeField]
    private GameObject Canvas;
    [SerializeField]
    private GameObject GameManager;


    [SerializeField]
    GameObject audioSource;


    void Start()
    {
        audioSource.GetComponent<MusicController>().PlayDance();   
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + points.ToString() + "/10";
        if (Fin == 4)
        {   if (points >= 10)
            {
                textSucces.enabled = true;
                GameManager.GetComponent<GameMaster>().setDance(5);

            }
            else
            {

                textDefaite.enabled = true;
            }

            Fin = 0;
            StartCoroutine(TimerEnd());

        }
    }

    void OnEnable()
    {
        Fin = 0;
        points = 0;
        textSucces.enabled = false;
        textDefaite.enabled = false;
        text.text = "Score: " + points.ToString() + "/10";
    }

    public void ajouterPoint()
    {
        points++;
    }

    public void fin()
    {
        Fin++;
    }


    IEnumerator TimerEnd ()
    {

        yield return new WaitForSeconds(3.0f);
        GameManager.GetComponent<GameMaster>().setJour(1);
        audioSource.GetComponent<MusicController>().PlayMenu();
        Menu.SetActive(true);
        textSucces.enabled = false;
        textDefaite.enabled = false;
        Canvas.SetActive(false);
    }
}
