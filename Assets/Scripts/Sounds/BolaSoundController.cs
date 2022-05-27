using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaSoundController : MonoBehaviour
{
    AudioSource bolaAudioSource;
    public AudioClip somPulo;
    public AudioClip somMorte;

    private void Start()
    {
        bolaAudioSource = GetComponent<AudioSource>();
    }

    public void playSound(int soundNum)
    {
        switch (soundNum)
        {
            case 1:
                bolaAudioSource.PlayOneShot(somPulo);
                break;
            case 2:
                bolaAudioSource.PlayOneShot(somMorte);
                break;
        }
    }
}
