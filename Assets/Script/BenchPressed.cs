using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BenchPressed : MonoBehaviour
{

    private float StartYPos;
    private float yPos;
    int maxLevel;
    bool Gamefinished;

    [SerializeField]
    GameObject WinScreen;

    [SerializeField]
    GameObject LooseScreen;

    [SerializeField]
    GameObject readyScreen;

    [SerializeField]
    GameObject GameMaster;

    [SerializeField]
    GameObject player;

    [SerializeField]
    Text startTimer;


    int difficulty;
    int Strenght;
    int hit;
    int hitPosition;
    int releaseRatio;
    bool start ;
    bool timerFinished;


    // Start is called before the first frame update
    void Start()
    {
        Gamefinished = false;
        StartYPos = this.transform.position.y;
        yPos = StartYPos;
        maxLevel = 11;
        hitPosition = 1;
        hit = 0;
        releaseRatio = 0;

        timerFinished = false;
        start = false;
        difficulty = 75;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Hit") && Gamefinished == false)

        {

            
            if (timerFinished == true)
            {
                hit += 1;
                //yPos += 2;
                //this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));
                if (hit == 2)
                {
                    hitPosition += 1;
                    player.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Benchpress/BenchAnimation_" + hitPosition.ToString());
                    hit = 0;
                }
            }

            if (start == false)
            {
                start = true;
                readyScreen.SetActive(false);  
                StartCoroutine(StartGame());
                
            }
        }

        releaseRatio++;

        if (releaseRatio >= difficulty && hitPosition != 1 && Gamefinished == false && start == true)
        {
            //yPos -= 0.1f;
            //this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));
            hitPosition -= 1;
            player.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Benchpress/BenchAnimation_" + hitPosition.ToString());
            releaseRatio = 0;
        }
            

        if (hitPosition == maxLevel)
        {
            // GameMaster.GetComponent<GameMaster>().setStrenght(5);
            WinScreen.SetActive(true);
            Gamefinished = true;



        }



    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(8.0f);

        if (Gamefinished == false)
        {
            LooseScreen.SetActive(true);
            Gamefinished = true;

        }
           
    }


    IEnumerator StartGame()
    {
        for (int i = 3; i> 0; i--)
        {
            startTimer.text = i.ToString();
            yield return new WaitForSeconds(1.0f);
            if (i == 1)
            {
                startTimer.text = "";
                timerFinished = true;
                StartCoroutine(Timer());
            }

        }
        


    }
}
