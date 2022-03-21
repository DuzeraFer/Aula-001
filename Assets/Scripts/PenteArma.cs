using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PenteArma : MonoBehaviour
{
    public int balasNoPente;
    public int balasNoCartucho;

    public TextMeshProUGUI balasNoPenteTxt;
    public TextMeshProUGUI balasNoCartuchoTxt;

    // Start is called before the first frame update
    void Start()
    {
        refreshInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reload()
    {
        if (balasNoPente < 30)
        {
            balasNoPente = balasNoPente + balasNoCartucho;

            balasNoCartucho = 0;
            if (balasNoPente > 30)
            {
                balasNoCartucho += balasNoPente - 30;
                balasNoPente = 30;
            }            
        }

        refreshInfo();
    }

    public void refreshInfo()
    {
        balasNoPenteTxt.text = balasNoPente.ToString();
        balasNoCartuchoTxt.text = balasNoCartucho.ToString();
    }
}
