using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class NewInputPlayer : MonoBehaviour
{
    public Vector2 valorInput;
    public float valorPulo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //entrada.Jogador.Pular.ReadValue<float>();
    }

    public void Mover(CallbackContext context)
    {
        valorInput = context.ReadValue<Vector2>();
        if (context.started)
        {
            Debug.Log("Started: " + context.control.displayName);
        }
        if (context.performed)
        {
            Debug.Log("Perfomed: " + context.control.displayName);
        }
        if (context.canceled)
        {
            Debug.Log("canceled: " + context.control.displayName);
        }
    }

    public void Pulo(CallbackContext context)
    {
        Debug.Log("Apertou a tecla: " + context.control.displayName);
        valorPulo = context.ReadValue<float>();
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}
