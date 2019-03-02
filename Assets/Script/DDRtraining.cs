using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDR : MonoBehaviour
{
    //Variables
    public float gravity = 20.0F;
    private Vector3 move;

    RectTransform DDRleft;
    double m_XAxis, m_YAxis;

    private void Start()
    {
        //Fetch the RectTransform from the GameObject
        DDRleft = GetComponent<RectTransform>();
        //Initiate the x and y positions
        move = DDRleft.position;
    }

    void Update()
    {
        m_YAxis = move.y - 1.0;
        move.Set(move.x, (float)m_YAxis, move.z);
        DDRleft.SetPositionAndRotation();

        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
    }
}
