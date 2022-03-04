using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTesouro : MonoBehaviour
{
    public Vector3 Girar;
    public float Força;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Girar * Força);
    }
}
