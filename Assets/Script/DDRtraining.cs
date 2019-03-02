using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDRtraining : MonoBehaviour
{
    //Variables
    private Vector3 move;
    public GameObject DDRleft;
    double m_YAxis;
    
    private static double statArrowY = -135;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the RectTransform from the GameObject
        //DDRleft = GetComponent<RectTransform>();

        //Initiate the x and y positions
        //move = DDRleft.position;
        move = DDRleft.GetComponent<RectTransform>().position;
       // move.Set((float)-112.5, 237, 0);
        //DDRleft.GetComponent<RectTransform>()
            //.SetPositionAndRotation(move, DDRleft.GetComponent<RectTransform>().rotation);
    }

    // Update is called once per frame
    void Update()
    {
        m_YAxis = move.y - 2.0;
        move.Set(move.x, (float)m_YAxis, move.z);
        DDRleft.GetComponent<RectTransform>()
            .SetPositionAndRotation(move, DDRleft.GetComponent<RectTransform>().rotation);

        if ((statArrowY + 40.0) >= m_YAxis)
            if(m_YAxis >= (statArrowY + 40.0))
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            { 
                Debug.Log(m_YAxis);
                this.enabled = false;
            }
        }
    }
}
