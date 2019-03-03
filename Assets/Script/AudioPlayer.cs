using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    [SerializeField]
    private AudioClip clickSound;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Click()
    {
        audioSource.PlayOneShot(clickSound, 2.5F);
    }

}
