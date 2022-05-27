using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSoundController : MonoBehaviour
{
    AudioSource weaponAudioSource;
    public AudioClip somTiro;

    private void Start()
    {
        weaponAudioSource = GetComponent<AudioSource>();
    }

    public void playSoundTiro()
    {
        weaponAudioSource.PlayOneShot(somTiro);
    }
}
