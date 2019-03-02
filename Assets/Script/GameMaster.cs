using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    [SerializeField]
    public Text week, intel, cardio, strenght, dance;

    private int Week, Intel, Cardio, Strenght, Dance;

    void Start()
    {
        Week = 2;
        week.text = Week.ToString();
        
    }

    
    void Update()
    {
        
    }

    public void setStrenght(int _strenght)
    {
        Strenght = _strenght;
        strenght.text = Strenght.ToString();

    }
}
