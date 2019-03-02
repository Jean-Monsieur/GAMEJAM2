using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BenchPressed : MonoBehaviour
{

    private float StartYPos;
    private float yPos;
    int maxLevel;
    bool win;

    [SerializeField]
    GameObject WinScreen;

    [SerializeField]
    GameObject LooseScreen;

    [SerializeField]
    GameObject GameMaster;

    [SerializeField]
    GameObject player;

    int Strenght;
    int hit;
    int hitPosition;
    int releaseRatio;

    // Start is called before the first frame update
    void Start()
    {
        win = false;
        StartYPos = this.transform.position.y;
        yPos = StartYPos;
        maxLevel = 11;
        hitPosition = 1;
        hit = 0;
        releaseRatio = 0;
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Hit") && hitPosition < maxLevel)
        {
            hit += 1;
            //yPos += 2;
            //this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));
            if (hit == 2)
            {
                hitPosition += 1;
                player.GetComponent<Image>().sprite =  Resources.Load<Sprite>("Sprites/Benchpress/BenchAnimation_" + hitPosition.ToString());
                hit = 0;
            }
            

        }

        releaseRatio++;

        if(releaseRatio == 50 && hitPosition != 1 && win == false)
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
            win = true;


        }



    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(8.0f);

        if(win == false)
            LooseScreen.SetActive(true);
    }


}
