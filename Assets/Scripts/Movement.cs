using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movX;
    public float movZ;
    public float speed = 150;
    public float forçaPulo;
    Rigidbody rgdb;

    public KeyCode paraFrente;
    public KeyCode paraTras;
    public KeyCode paraDireita;
    public KeyCode paraEsquerda; 

    bool podePular = false;

    // Start is called before the first frame update
    void Start()
    {
        rgdb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1)
        {
            transform.position = new Vector3(0, 1, 0);
        }

        #region Primeira maneira de pegar o valor do jogador
        //movX = Input.GetAxis("Horizontal");
        //movZ = Input.GetAxis("Vertical");
        #endregion

        #region Segunda maneira de pegar o valor do jogador
        if (Input.GetKey(paraFrente))
        {
            movZ = 1;
        }
        else if (Input.GetKeyUp(paraFrente))
        {
            movZ = 0;
        }

        if (Input.GetKey(paraTras))
        {
            movZ = -1;
        }
        else if (Input.GetKeyUp(paraTras))
        {
            movZ = 0;
        }

        if (Input.GetKey(paraDireita))
        {
            movX = 1;
        }
        else if (Input.GetKeyUp(paraDireita))
        {
            movX = 0;
        }

        if (Input.GetKey(paraEsquerda))
        {
            movX = -1;
        }
        else if (Input.GetKeyUp(paraEsquerda))
        {
            movX = 0;
        }

        if (Input.GetKey(paraFrente) && Input.GetKey(paraTras))
        {
            movZ = 0;
        }
        if (Input.GetKey(paraEsquerda) && Input.GetKey(paraDireita))
        {
            movX = 0;
        }
        #endregion

        Vector3 move = new Vector3(movX * Time.deltaTime, 0, movZ * Time.deltaTime);

        #region Primeira forma de movimento (translate)
        //transform.Translate(move * speed);
        #endregion

        #region Segunda forma de movimento (add force)
        rgdb.AddForce(move * speed);
        #endregion

        #region Terceira forma de movimento (velocity)
        //rgdb.velocity = move * speed;
        #endregion

        #region Pulo
        if (Input.GetKeyDown(KeyCode.Space) && podePular)
        {
            rgdb.AddForce(Vector3.up * forçaPulo, ForceMode.Impulse);
        }
        #endregion
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Chão")
        {
            podePular = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Chão")
        {
            podePular = false;
        }
    }
}
