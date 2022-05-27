using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoSoundController : MonoBehaviour
{
    public bool isPlaying;
    AudioSource audioAviaoController;

    private void Start()
    {
        audioAviaoController = GetComponent<AudioSource>();
    }

    public void startEngineSound()
    {
        isPlaying = true;
        audioAviaoController.Play();
    }

    public void stopEngineSound()
    {
        isPlaying = false;
        audioAviaoController.Stop();
    }
}
