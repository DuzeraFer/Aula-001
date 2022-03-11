using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public Text speedTxt;
    public Text timeTxt;
    public Text pointsTxt;

    private int points = 0;

    float time;

    bool speedBuff;

    Movement movimento;

    // Start is called before the first frame update
    void Start()
    {
        movimento = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

        if (speedBuff == true && time > 3)
        {
            speedBuff = false;
            movimento.speed -= 150;
            time = 0;
        }

        speedTxt.text = "Velocidade: " + movimento.speed.ToString();
        timeTxt.text = "Tempo: " + time.ToString("00.00");
        pointsTxt.text = "Pontos: " + points;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tesouro")
        {
            points++;
            Destroy(other.gameObject);
            print(points);
        }

        if (other.gameObject.tag == "Speed")
        {
            time = 0;
            movimento.speed += 150;
            speedBuff = true;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "ParedeQuebra" && movimento.speed > 200)
        {
            Destroy(other.gameObject);
        }
    }
}
