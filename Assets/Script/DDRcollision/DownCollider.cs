using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCollider : MonoBehaviour
{
    public ScoreHandler GameControler;
    private int CountArrow;

    void start()
    {
        GameControler = GetComponent<ScoreHandler>();
    }

    void OnEnable()
    {
        CountArrow = 0;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
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
