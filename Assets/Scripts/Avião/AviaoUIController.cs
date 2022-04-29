using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AviaoUIController : MonoBehaviour
{
    AviaoController aviaoController;

    public Text counterText;

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
    }
}
