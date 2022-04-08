using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaoController : MonoBehaviour
{
    public GameObject camera1P;
    public GameObject camera3P;
    public GameObject cameraBack;

    public AviaoController controleAviao;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controleAviao.liga)
        {
            camera1P.SetActive(true);
            camera3P.SetActive(true);
            cameraBack.SetActive(true);
        }
        else
        {
            camera1P.SetActive(false);
            camera3P.SetActive(false);
            cameraBack.SetActive(false);
        }
    }
}
