using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Fille qui trip sur les gros muscle*/
public class NPC_1 : MonoBehaviour
{
    private int BaseStrengh = 5;
    private int BaseCardio = 2;
    private int BaseDance = 2;
    private int BaseIntel = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Methode pour savoir si les statistique requise sont atteinte.**
     *Retourne le nom du dialog à utiliser**/
    public string coochieGetter(int week, int intel, int cardio, int strengh, int dance)
    {
        //updateBaseStats(week);

        if (intel >= BaseIntel)
            if (cardio >= BaseCardio)
                if (strengh >= BaseStrengh)
                    if (dance >= BaseDance)
                        return "Dialog1";

        return "Dialog2";
    }

    /*
    public void updateBaseStats()
    {
        //Adapter les valeurs par rapport à la semaine
        
        double constWeek = week * 0.3;
        int intelNeeded = (int)Math.Round(intel + (intel * constWeek));
        
    }
    //*/



}
