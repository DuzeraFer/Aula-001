using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMira : MonoBehaviour
{
    [Header("Laser")]
    public GameObject miraLaser;
    public KeyCode habLaser;

    [Header("Mira")]
    public Camera cameraMira;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(habLaser))
        {
            miraLaser.SetActive(!miraLaser.activeSelf);
        }

        if (Input.GetMouseButtonDown(1))
        {
            cameraMira.depth = 2;
        }
        if (Input.GetMouseButtonUp(1))
        {
            cameraMira.depth = 0;
        }
    }
}
