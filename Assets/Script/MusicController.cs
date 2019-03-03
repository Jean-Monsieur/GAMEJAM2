using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    [SerializeField]
    private AudioClip menu,dance,club,chatter;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;

    }

    public void PlayMenu()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(menu, 2.5F);
    }
    public void PlayDance()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(dance, 2.5F);
    }
    public void PlayClub()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(club, 2.5F);
    }
    public void PlayChatter()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(chatter, 2.5F);
    }

    //public IEnumerator StartSound()
    //{
    //    audioSource.PlayOneShot(clickSound, 2.5F);
    //    yield return new WaitForSeconds(1.0f);
    //    audioSource.PlayOneShot(maleYeah, 2.5F);
    //}



}
