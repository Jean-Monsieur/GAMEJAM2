using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDRtraining : MonoBehaviour
{
    //Variables
    private Vector3 move;

    public GameObject DDRleft;
    double m_XAxis, m_YAxis;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the RectTransform from the GameObject

        //DDRleft = GetComponent<RectTransform>();

        //Initiate the x and y positions
        //move = DDRleft.position;
        move = DDRleft.GetComponent<RectTransform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        m_YAxis = move.y - 1.0;
        move.Set(move.x, (float)m_YAxis, move.z);
        DDRleft.GetComponent<RectTransform>().SetPositionAndRotation(move, DDRleft.GetComponent<RectTransform>().rotation);
    }
}
