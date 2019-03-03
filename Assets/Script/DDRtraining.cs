using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DDRtraining : MonoBehaviour
{
    //Variables
    //public Text text;
    private Vector3 move;
    public GameObject DDRArrow;
    private RectTransform Arrow;
    private RectTransform Arrows;

    double m_YAxis;
    private int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        Arrow = DDRArrow.GetComponent<RectTransform>();
        move = Arrow.position;
    }

    // Update is called once per frame
    void Update()
    {


        m_YAxis = move.y - 2.0;
        move.Set(move.x, (float)m_YAxis, move.z);
        Arrow.SetPositionAndRotation(move, Arrow.rotation);
        
    }

    public void ajouterPoint()
    {
        points += 1;
        Debug.Log(points);
    }
    
}
