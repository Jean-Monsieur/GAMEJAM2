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
        audioSource.PlayOneShot(clickSound, 3f);
    }

    public IEnumerator StartSound()
    {
        audioSource.PlayOneShot(clickSound, 3f);
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(maleYeah, 3f);
    }
    public void Play1()
    {
        audioSource.PlayOneShot(Sound1, 3f);
    }

    public void Play2()
    {
        audioSource.PlayOneShot(Sound2, 3f);
    }

    public void Play3()
    {
        audioSource.PlayOneShot(Sound3, 3f);
    }

    public void PlayGo()
    {
        audioSource.PlayOneShot(Soundgo,3f);
    }

    public void PlayYeah()
    {
        audioSource.PlayOneShot(maleYeah, 3f);
    }
    public void PlayFemaleWin()
    {
        audioSource.PlayOneShot(femaleMyPleasure, 3f);
    }
    public void PlayFemaleLoss()
    {
        audioSource.PlayOneShot(femaleUgh, 3f);
    }
    public void PlayMaleDefeat()
    {
        audioSource.PlayOneShot(maleReally, 3f);
    }
    public void PlayMaleWin()
    {
        audioSource.PlayOneShot(maleYouGotIt, 3f);
    }

}
