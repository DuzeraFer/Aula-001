using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour
{
    public AudioMixer audioMix;

    public float somArea;
    public float somPiano;

    void Start()
    {
        
    }

    void Update()
    {
        //audioMix.GetFloat("volumeArea", out somArea);
        //audioMix.GetFloat("volumePiano", out somPiano);

        audioMix.SetFloat("volumeArea", somArea);
        audioMix.SetFloat("volumePiano", somPiano);
    }
}
