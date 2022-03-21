using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleRifle : MonoBehaviour
{
    public GameObject canoDaArma;
    public GameObject bala;

    public KeyCode botaoRecarregar;

    PenteArma penteArmaScript;

    // Start is called before the first frame update
    void Start()
    {
        penteArmaScript = GetComponent<PenteArma>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && penteArmaScript.balasNoPente > 0)
        {
            var b = Instantiate(bala, canoDaArma.transform.position, canoDaArma.transform.rotation);
            Destroy(b, 5);

            penteArmaScript.balasNoPente -= 1;

            penteArmaScript.refreshInfo();
        }
        else if (Input.GetMouseButtonDown(0) && penteArmaScript.balasNoPente == 0)
        {
            penteArmaScript.Reload();
        }

        if (Input.GetKeyDown(botaoRecarregar))
        {
            penteArmaScript.Reload();
        }
    }
}
