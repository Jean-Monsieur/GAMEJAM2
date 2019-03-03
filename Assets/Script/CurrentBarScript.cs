using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CurrentBarScript : MonoBehaviour
{

    string bar;
    [SerializeField]
    GameObject LogoVM, LogoDAG, LogoBaru, LogoBiss;

    bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {
         toggle = false;
        switch (GetBar())
        {
            case 1:
                bar = "VM";
                LogoVM.SetActive(!toggle);
                break;
            case 2:
                bar = "DAG";
                LogoDAG.SetActive(!toggle);
                break;
            case 3:
                bar = "BARU";
                LogoBaru.SetActive(!toggle);
                break;
            case 4:
                bar = "BISS";
                LogoBiss.SetActive(!toggle);
                break;
        }
        Debug.Log(GetBar().ToString());
        Debug.Log(bar);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GetBar()
    {

        int bar = Random.Range(1, 5);

        return bar;
    }
}
