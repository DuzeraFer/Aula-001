using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleBala : MonoBehaviour
{
    Rigidbody rgbdBala;
    public float speed;

    ParedeQuebra paredeQuebraScript;

    // Start is called before the first frame update
    void Start()
    {
        rgbdBala = GetComponent<Rigidbody>();
        rgbdBala.AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ParedeQuebra")
        {
            paredeQuebraScript = collision.gameObject.GetComponent<ParedeQuebra>();
            paredeQuebraScript.LevarDano();
        }

        Destroy(gameObject);
    }
}
