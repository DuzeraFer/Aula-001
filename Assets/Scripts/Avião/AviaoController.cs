using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoController : MonoBehaviour
{
    [Header("Principal")]
    public bool liga;
    Rigidbody rBody;

    [Header("Hélice")]
    public Transform helice;
    public float speedHelice;
    float inicialSpeedHelice = 1;

    [Header("Input Avião")]
    public KeyCode acelerar;
    public KeyCode frear;
    public KeyCode paraCima;
    public KeyCode paraBaixo;
    public KeyCode esquerda;
    public KeyCode direita;
    public float speedAviao = 0;
    public float speedGiro;

    [Header("Player")]
    public GameObject m_player;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (liga)
        {
            if (RotateHelice())
            {
                Movimento();
            }
        }
        else inicialSpeedHelice = 1;
    }

    public bool RotateHelice()
    {
        if (inicialSpeedHelice < speedHelice)
        {
            inicialSpeedHelice++;
        }     
        helice.Rotate(new Vector3(0, 1 * inicialSpeedHelice * Time.deltaTime, 0));

        if (inicialSpeedHelice > (speedHelice / 3))
        {
            return true;
        }
        else
            return false;
    }

    public void Movimento()
    {
        float movZ = 0;
        float movX = 0;
        float movY = 0;

        if (Input.GetKey(acelerar))
        {
            speedAviao++;
        }
        if (Input.GetKey(frear) || !Input.GetKey(acelerar))
        {
            if (speedAviao > 0)
            {
                speedAviao = - 0.5f;
            }
            if (speedAviao == 0.5f)
            {
                speedAviao = 0;
            }
        }
       
        //Cima diminui X, Baixo aumenta em X
        if (Input.GetKey(paraCima))
        {
            movX = -1;
        }
        if (Input.GetKey(paraBaixo))
        {
            movX = 1;
        }

        //Direita aumenta Z, Esquerda diminui Z
        if (Input.GetKey(direita))
        {
            movZ = 1;
        }
        if (Input.GetKey(esquerda))
        {
            movZ = -1;
        }
        if (Input.GetKey(direita))
        {
            movY = 1;
        }
        if (Input.GetKey(esquerda))
        {
            movY = -1;
        }

        transform.Translate(Vector3.down * speedAviao * Time.deltaTime);
        transform.Rotate(new Vector3(movX * speedGiro * Time.deltaTime, movY * speedGiro * Time.deltaTime, movZ * speedGiro * Time.deltaTime));

        if (!Input.GetKey(acelerar) && transform.position.y > 20 && speedAviao < 100)
        {
            if (transform.rotation.x < -55f)
            {
                transform.Rotate(new Vector3(3 * Time.deltaTime, 0, 0));
            }          
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            m_player.SetActive(false);
            liga = true;

            rBody.constraints = RigidbodyConstraints.None;
        }
    }
}
