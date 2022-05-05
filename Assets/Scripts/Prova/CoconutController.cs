using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutController : MonoBehaviour
{
    public GameObject canvasUI;
    UIController uIController;

    private void Start()
    {
        uIController = canvasUI.GetComponent<UIController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pedra"))
        {
            uIController.AddCocos();
        }

        if (collision.gameObject.CompareTag("Palmeira"))
        {
            Debug.Log("hitou Palmeira");
        }
    }
}
