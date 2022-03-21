using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedeQuebra : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Material mat3;

    int hp;

    private void Start()
    {
        hp = 3;
        gameObject.GetComponent<Renderer>().material = mat3;
    }

    public void LevarDano()
    {
        hp--;

        switch (hp)
        {
            default:
                break;
            case 0:
                Destroy(gameObject);
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material = mat1;
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material = mat2;
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            LevarDano();
        }
    }
}
