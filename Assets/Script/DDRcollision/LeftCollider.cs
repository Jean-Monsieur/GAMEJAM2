using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCollider : MonoBehaviour
{
    public ScoreHandler GameControler;
    private int CountArrow;

    void start()
    {
        GameControler = GetComponent<ScoreHandler>();
        CountArrow = 0;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameControler.ajouterPoint();
            Destroy(collision.gameObject);
            CountArrow++;
            if (CountArrow >= 5)
                GameControler.fin();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {

        CountArrow++;
        if (CountArrow >= 5)
            GameControler.fin();
        Destroy(collision.gameObject, 0.3f);
    }
}
