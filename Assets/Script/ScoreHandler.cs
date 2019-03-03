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
    

    void Start()
    {
        textSucces.enabled = false;
        textDefaite.enabled = false;
        text.text = "Score: " + points.ToString() + "/10";
        Fin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + points.ToString() + "/10";
        if (Fin == 4)
            if (points > 10)
                textSucces.enabled = true;
            else
                textDefaite.enabled = true;
    }

    public void ajouterPoint()
    {
        points++;
    }

    public void fin()
    {
        Fin++;
    }
}
