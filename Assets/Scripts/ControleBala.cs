using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleBala : MonoBehaviour
{
    Rigidbody rgbdBala;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rgbdBala = GetComponent<Rigidbody>();
        rgbdBala.AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
