﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunScript : MonoBehaviour
{

    [SerializeField]
    Animator animator;

    [SerializeField]
    Text StartTimer;

    [SerializeField]
    GameObject GameMaster;

    [SerializeField]
    GameObject LooseScreen;

    [SerializeField]
    GameObject Menu;

    [SerializeField]
    GameObject leftArrow,rightArrow;

    [SerializeField]
    Canvas canvas;

    [SerializeField]
    Text startTimer;

    [SerializeField]
    private GameObject audioSource;

    private int timer;
    private Rigidbody2D rb2d;
    private string lastInput;
    private Vector2 movement;
    private bool gamestarted=false, timerFinished, gameFinished, shouldExecute,togglearrow =true;


    // Start is called before the first frame update
   public void Commencer()
    {
        animator.enabled = true;
        shouldExecute = true;
        timer = 11;
        lastInput = "right";
        rb2d = this.GetComponent<Rigidbody2D>();
        rb2d.position = new Vector2(-90f, 0f);
        movement = new Vector2(50f, 0f);
        rb2d.AddForce(movement);
        gameFinished = false;
        timerFinished = false;
        StartCoroutine(Countdown());
        StartCoroutine(inputTimer());
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        if (rb2d.position.x >= 70)
        {
            gameFinished = true;
            rb2d.velocity = new Vector2(0f, 0f);
        }

        //icitte set ton star
        if (timerFinished != true && gameFinished != true & gamestarted !=false)
        {
            movement = new Vector2(50f, 0f);
            if (lastInput == "right" && Input.GetKey("left"))
            {
                lastInput = "left";
                rb2d.AddForce(movement);
            }
            else if (lastInput == "left" && Input.GetKey("right"))
            {
                lastInput = "right";
                rb2d.AddForce(movement);
            }
        }
        else
        {
            if (gameFinished && shouldExecute)
            {
                GameMaster.GetComponent<GameMaster>().setCardio(5);
                shouldExecute = false;
                animator.enabled = false;
                StartCoroutine(GameMaster.GetComponent<ButtonHandler>().TexteGrossis(this.transform.parent.gameObject));
            }
            if (timerFinished && shouldExecute)
            {
                shouldExecute = false;
                animator.enabled = false;
                rb2d.velocity = new Vector2(0f, 0f);
                LooseScreen.SetActive(true);
                StartCoroutine(TimerEnd());

            }
        }
    }

    IEnumerator Countdown()
    {
        audioSource.GetComponent<AudioPlayer>().Play3();
        for (int i = 3; i > 0; i--)
        {
            startTimer.text = i.ToString();
            yield return new WaitForSeconds(1.0f);
            if (i == 2)
                audioSource.GetComponent<AudioPlayer>().Play1();
            if (i == 3)
                audioSource.GetComponent<AudioPlayer>().Play2();
        }
        gamestarted = true;
        StartCoroutine(Timer());
        audioSource.GetComponent<AudioPlayer>().PlayGo();
    }

    IEnumerator Timer()
    {
        audioSource.GetComponent<AudioPlayer>().PlayGo();
        for (int i = 6; i >= 0; i--)
        {
            if(gameFinished!= true)
                StartTimer.text = i.ToString();
            if(i == 0)
                timerFinished = true;
            yield return new WaitForSeconds(1.0f);
        }
        
    }
    IEnumerator inputTimer()
    {
        while (gameFinished!=true && timerFinished !=true)
        {
            togglearrow = !togglearrow;
            leftArrow.SetActive(togglearrow);
            rightArrow.SetActive(!togglearrow);
            yield return new WaitForSeconds(0.1F);
        }

    }


    IEnumerator TimerEnd()
    {
        yield return new WaitForSeconds(3.0f);
        LooseScreen.SetActive(false);
        Menu.SetActive(true);
        canvas.gameObject.SetActive(false);

    }
}
