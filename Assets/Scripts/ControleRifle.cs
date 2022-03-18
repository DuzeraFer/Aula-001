using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleRifle : MonoBehaviour
{
    public GameObject canoDaArma;
    public GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var b = Instantiate(bala, canoDaArma.transform.position, canoDaArma.transform.rotation);
            Destroy(b, 5);
        }
    }
}
