using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    [SerializeField]
    private AudioClip clickSound,Sound1,Sound2,Sound3,Soundgo,maleYeah,femaleMyPleasure,femaleUgh,maleReally,maleYouGotIt;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Click()
    {
        audioSource.PlayOneShot(clickSound, 2.5F);
    }

    public IEnumerator StartSound()
    {
        audioSource.PlayOneShot(clickSound, 2.5F);
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(maleYeah, 2.5F);
    }
    public void Play1()
    {
        audioSource.PlayOneShot(Sound1, 2.5F);
    }

    public void Play2()
    {
        audioSource.PlayOneShot(Sound2, 2.5F);
    }

    public void Play3()
    {
        audioSource.PlayOneShot(Sound3, 2.5F);
    }

    public void PlayGo()
    {
        audioSource.PlayOneShot(Soundgo,2.5F);
    }

    public void PlayYeah()
    {
        audioSource.PlayOneShot(maleYeah, 2.5F);
    }
    public void PlayFemaleWin()
    {
        audioSource.PlayOneShot(femaleMyPleasure, 2.5F);
    }
    public void PlayFemaleLoss()
    {
        audioSource.PlayOneShot(femaleUgh, 2.5F);
    }
    public void PlayMaleDefeat()
    {
        audioSource.PlayOneShot(maleReally, 2.5F);
    }
    public void PlayMaleWin()
    {
        audioSource.PlayOneShot(maleYouGotIt, 2.5F);
    }

}
