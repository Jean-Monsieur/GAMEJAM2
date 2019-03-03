using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendScript : MonoBehaviour
{
    [SerializeField]
    private GameObject audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.GetComponent<MusicController>().PlayMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
