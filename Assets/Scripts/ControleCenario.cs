using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCenario : MonoBehaviour
{
    public Transform agua;
    public Transform jogador;
    public Color corDaAgua;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador.position.y < agua.position.y)
        {
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.Exponential;
            RenderSettings.fogDensity = 0.01f;
            RenderSettings.fogColor = corDaAgua;
        }
        else
        {
            RenderSettings.fog = false;
        }
    }
}
