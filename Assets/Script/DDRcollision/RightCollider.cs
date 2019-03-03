using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Plus 1 pts!");
            this.enabled = false;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Plus 1 pts!");
            this.enabled = false;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Plus 1 pts!");
            this.enabled = false;
        }
    }
}
