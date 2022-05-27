using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArosGasolina : MonoBehaviour
{
    public static float counterAro = 300f;

    private void FixedUpdate()
    {
        counterAro = counterAro - Time.fixedDeltaTime;

        if (counterAro < 0)
        {
            Destroy(gameObject);
        }
    }
}
