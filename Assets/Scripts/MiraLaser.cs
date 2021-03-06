using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraLaser : MonoBehaviour
{
    public float distance;
    LineRenderer laser;

    // Start is called before the first frame update
    void Start()
    {
        laser = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        laser.SetPosition(0, transform.position);
        laser.SetPosition(1, transform.position + transform.forward * distance);
    }
}
