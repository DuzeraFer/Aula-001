using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedraController : MonoBehaviour
{
    Rigidbody rgdbPedra;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rgdbPedra = GetComponent<Rigidbody>();
        rgdbPedra.AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coconut"))
        {
            Rigidbody rgdbCoco = collision.gameObject.GetComponent<Rigidbody>();
            rgdbCoco.constraints = RigidbodyConstraints.None;
            rgdbCoco.useGravity = true;         
        }

        Destroy(gameObject);       
    }
}
