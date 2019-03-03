using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheSituation : MonoBehaviour
{


    [SerializeField]
    GameObject Mike1, Mike2, Biblio, Danse, Jogging, Gym;
    [SerializeField]
    Image image;

    [SerializeField]
    GameObject audio;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        Mike1.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        Mike1.SetActive(false);
        Mike2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        Mike2.SetActive(false);
        var tempColor = image.color;
        tempColor.a = 1f;
        image.color = tempColor;
        Biblio.SetActive(true);
        Danse.SetActive(true);
        Jogging.SetActive(true);
        Gym.SetActive(true);
      




    }

    private void OnEnable()
    {
        audio.GetComponent<MusicController>().PlayMenu();
    }
}
