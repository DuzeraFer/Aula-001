using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapController : MonoBehaviour
{
    Camera miniMapCam;

    void Start()
    {
        miniMapCam = gameObject.GetComponent<Camera>();    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2)) StartCoroutine(HabilitCamera());
    }

    IEnumerator HabilitCamera()
    {
        miniMapCam.depth = 2;

        yield return new WaitForSeconds(5);

        miniMapCam.depth = 0;
    }
}
