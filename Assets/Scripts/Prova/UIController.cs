using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text quantidadeCocosText;
    public Text tempoText;

    bool contadorTempo;

    float tempo;
    float quantidadeCocos;

    private void Start()
    {
        quantidadeCocos = 0;
        contadorTempo = true;
        tempo = 0;
    }

    private void Update()
    {
        if (contadorTempo) tempo = tempo + Time.deltaTime;

        System.TimeSpan time = System.TimeSpan.FromSeconds(tempo);
        tempoText.text = time.ToString("mm':'ss");
    }

    public void AddCocos()
    {
        if (contadorTempo)
        {
            quantidadeCocos++;
            quantidadeCocosText.text = quantidadeCocos.ToString();

            if (quantidadeCocos == 12)
            {
                contadorTempo = false;
            }
        }      
    }
}
