using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArosGasolina : MonoBehaviour
{
    public float counterAro = 300f;

    private void Update()
    {
        counterAro = counterAro - Time.deltaTime;

        if (counterAro < 0)
        {
            Destroy(gameObject);
        }
    }
}
