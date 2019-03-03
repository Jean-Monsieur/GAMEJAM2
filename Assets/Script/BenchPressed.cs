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
	
	[SerializeField]
	GameObject SpaceBarIcon;

    [SerializeField]
    private GameObject audioSource;

    [SerializeField]
    GameObject Menu;

    int difficulty;
    int Strenght;
    int hit;
    int hitPosition;
    int releaseRatio;
    bool start ;
    bool timerFinished;
	bool isActive;


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
		isActive = true;
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
				SpaceBarIcon.SetActive(isActive);
				isActive = !isActive;
                hit += 1;
                
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
            
            hitPosition -= 1;
            player.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Benchpress/BenchAnimation_" + hitPosition.ToString());
            releaseRatio = 0;
        }
            

        if (hitPosition == maxLevel)
        {
            if (Gamefinished == false)
            {
                GameMaster.GetComponent<GameMaster>().setStrenght(5);
                StartCoroutine(GameMaster.GetComponent<ButtonHandler>().TexteGrossis(this.transform.parent.gameObject));
                
            }
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
            StartCoroutine(TimerEnd());

        }
           
    }


    IEnumerator StartGame()
    {
        audioSource.GetComponent<AudioPlayer>().Play3();
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
            if (i == 2)
                audioSource.GetComponent<AudioPlayer>().Play1();
            if (i==3)
                audioSource.GetComponent<AudioPlayer>().Play2();
        }
        audioSource.GetComponent<AudioPlayer>().PlayGo();
        


    }


    IEnumerator TimerEnd()
    {
        yield return new WaitForSeconds(3.0f);

        Menu.SetActive(true);
        this.gameObject.SetActive(false);

    }
}

