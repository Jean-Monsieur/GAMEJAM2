using System.Collections;
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
    Canvas canvas;

    private int timer;
    private Rigidbody2D rb2d;
    private string lastInput;
    private Vector2 movement;
    private bool timerFinished, gameFinished, shouldExecute;

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
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (rb2d.position.x >= 70)
        {
            gameFinished = true;
            rb2d.velocity = new Vector2(0f, 0f);
        }
        if (timerFinished != true && gameFinished != true)
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
    IEnumerator Timer()
    {
        for (int i = 6; i >= 0; i--)
        {
            if(gameFinished!= true)
                StartTimer.text = i.ToString();
            if(i == 0)
                timerFinished = true;
            yield return new WaitForSeconds(1.0f);

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
