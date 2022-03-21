using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public GameObject arma;
    public GameObject balasNoPenteText;
    public GameObject interfaceArma;

    PenteArma penteArmaScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Arma")
        {
            arma.SetActive(true);
            balasNoPenteText.SetActive(true);
            interfaceArma.SetActive(true);

            penteArmaScript = arma.GetComponent<PenteArma>();

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Bala" && arma.activeSelf == true)
        {
            penteArmaScript.balasNoPente = 30;
            penteArmaScript.refreshInfo();

            Destroy(other.gameObject);
        }
    }
}
