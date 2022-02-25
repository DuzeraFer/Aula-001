using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject bolinha;
    Vector3 posInicial;
    Vector3 posAtual;
    
    // Start is called before the first frame update
    void Start()
    {
        posInicial = bolinha.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posAtual = bolinha.transform.position;
        transform.position = transform.position + (posAtual - posInicial);
        posInicial = bolinha.transform.position;
    }
}
