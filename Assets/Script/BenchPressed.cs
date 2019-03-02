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

    // Start is called before the first frame update
    void Start()
    {
        win = false;
        StartYPos = this.transform.position.y;
        yPos = StartYPos;
        maxLevel = 11;
        hitPosition = 1;
        hit = 0;
        //StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Hit") && yPos <= maxLevel)
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

        if(yPos > StartYPos && yPos <= maxLevel)
        {
            yPos -= 0.1f;
            this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));

        }


        if (hit == maxLevel)
        {
            GameMaster.GetComponent<GameMaster>().setStrenght(5);
            WinScreen.SetActive(true);
            
        }



    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5.0f);

        if(win == false)
            LooseScreen.SetActive(true);
    }


}
