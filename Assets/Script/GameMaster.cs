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
}
