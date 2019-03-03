using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DDRtraining : MonoBehaviour
{
    //Variables
    //public Text text;
   public GameObject DDRArrow;
    private RectTransform Arrow;
    private RectTransform[] Arrows;
    private Vector3[] move;

    private static int ARROWMAX = 5;

    [SerializeField]
    private GameObject Parent;

    // Start is called before the first frame update
    void Awake()
    {
        Arrow = DDRArrow.GetComponent<RectTransform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < ARROWMAX; i++)
        {
            if(Arrows[i] != null)
            {
                move[i].Set(move[i].x, (float)(move[i].y - 1), move[i].z);
                Arrows[i].SetPositionAndRotation(move[i], Arrows[i].rotation);
            }
        }
    }

    public void ajouterPoint() { }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));

        for (int x = 0; x < ARROWMAX; x++)
        {
            Arrows[x] = (Instantiate(Arrow, Arrow.position, Arrow.rotation, Parent.transform));
            move[x] = (Arrows[x].position);
            
            float temps = Random.Range(3.0f, 5.0f);
            yield return new WaitForSeconds(temps);

        }
        
    }

    public void StartTimer()
    {
        Timerloading();
        move = new Vector3[ARROWMAX];
        Arrows = new RectTransform[ARROWMAX];
        StartCoroutine(Timer());

    }

    IEnumerator Timerloading()
    {

        yield return new WaitForSeconds(1.0f);
    }
}
