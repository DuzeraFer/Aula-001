using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogarPedraController : MonoBehaviour
{
    public GameObject pedra;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var b = Instantiate(pedra, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(b, 5);
        }
    }
}
