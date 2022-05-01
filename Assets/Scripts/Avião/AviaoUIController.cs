using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AviaoUIController : MonoBehaviour
{
    AviaoController aviaoController;

    public Text counterText;
    public Text pointsText;
    public Text timerAroText;

    private void Start()
    {
        aviaoController = GetComponent<AviaoController>();
    }

    private void Update()
    {
        if (aviaoController.counter > 0)
        {
            counterText.text = aviaoController.counter.ToString();
        }

        if (aviaoController.counter < 0)
        {
            counterText.text = "0";
        }

        System.TimeSpan time = System.TimeSpan.FromSeconds(ArosGasolina.counterAro);
        timerAroText.text = time.ToString("mm':'ss");

        pointsText.text = aviaoController.points.ToString();
    }
}
