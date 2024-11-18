using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  Este script controla un personaje en un entorno 3D, le permite saltar cuando est� en el suelo
    y cambia el color de un texto en pantalla para indicar si est� en el suelo o no. */

/*  El atributo [RequireComponent(typeof(Rigidbody))] asegura que el GameObject al que adjuntamos
    este script tenga un Rigidbody (componente necesario para las f�sicas). */
[RequireComponent(typeof(Rigidbody))]
public class PlayerController3D : MonoBehaviour
{
    /// <summary>
    /// Guardamos el componente Rigidbody del personaje, que se encargar� de las f�sicas
    /// </summary>
    private Rigidbody rb;

    /// <summary>
    /// Esta variable nos dice si el personaje est� tocando el suelo o no
    /// </summary>
    private bool isGrounded;

    /// <summary>
    /// Fuerza con la que el personaje saltar�. Se puede modificar en el inspector de Unity.
    /// </summary>
    [SerializeField]
    private float jumpForce = 10.0f;

    /// <summary>
    /// La posici�n de los "pies" del personaje, usada para emitir un rayo 
    /// hacia el suelo y verificar si est� en el suelo.
    /// </summary>
    [SerializeField]
    private Transform feet;

    /// <summary>
    /// Referencia a un objeto de texto en pantalla (TextMeshPro), que cambia 
    /// de color dependiendo de si el personaje est� en el suelo o no.
    /// </summary>
    [SerializeField]
    private TMPro.TextMeshProUGUI groundedText;

    /// <summary>
    /// El m�todo Awake() se llama cuando el script se activa por primera vez. 
    /// Aqu� obtenemos el componente Rigidbody que est� en el mismo GameObject.
    /// </summary>
    private void Awake()
    {
        // Asignamos el componente Rigidbody a nuestra variable rb.
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// El m�todo Update() se llama una vez por frame. Aqu� verificamos si el 
    /// personaje puede saltar y actualizamos el texto en pantalla.
    /// </summary>
    void Update()
    {
        // Comprobamos si el personaje est� en el suelo.
        CheckGrounded();

        // Cambiamos el color del texto seg�n si el personaje est� en el suelo o no.
        ChangeTextColor();

        // Si se pulsa la barra espaciadora y el personaje est� en el suelo, puede saltar.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();  // Llamamos a la funci�n para hacer saltar al personaje.
            }
        }
    }

    /// <summary>
    /// Este m�todo emite un rayo desde la posici�n de los "pies" del personaje 
    /// hacia abajo para verificar si hay suelo a una distancia de 0.5 unidades.
    /// </summary>
    private void CheckGrounded()
    {
        // Physics.Raycast emite un rayo hacia abajo desde la posici�n de los pies (feet.position).
        // Si el rayo detecta una colisi�n con un objeto del "Ground" LayerMask, isGrounded ser� verdadero.
        isGrounded = Physics.Raycast(feet.position, Vector3.down, 0.5f, LayerMask.GetMask("Ground"));
    }

    /// <summary>
    /// Este m�todo cambia el color del texto en pantalla seg�n si el personaje est� o no en el suelo.
    /// </summary>
    private void ChangeTextColor()
    {
        // Si el personaje est� en el suelo, el texto se vuelve verde. Si no, se vuelve rojo.
        if (isGrounded)
        {
            groundedText.color = Color.green;  // Verde si est� en el suelo.
        }
        else
        {
            groundedText.color = Color.red;  // Rojo si est� en el aire.
        }
    }

    /// <summary>
    /// Este m�todo aplica una fuerza hacia arriba para hacer que el personaje salte.
    /// </summary>
    private void Jump()
    {
        // Generamos una direcci�n de salto aleatoria en 2D (hacia arriba con una peque�a variaci�n horizontal).
        Vector2 randomDirection = new Vector2(Random.Range(-1.0f, 1.0f), 1.0f);

        // Aplicamos una fuerza al Rigidbody en la direcci�n aleatoria multiplicada por la fuerza de salto.
        rb.AddForce(randomDirection * jumpForce);
    }
}
