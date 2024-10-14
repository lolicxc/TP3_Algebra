using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f; // velocidad
    public float mouse = 2.0f; // sensibilidad del mouse

    public float verticalRotation = 0;

    void Update()
    {
       
    }

    // movimiento de camara
    private void MoveCamera()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3 (horizontalInput, verticalInput);
        direccion = player.TransformDirection(direccion);
        direccion.y = verticalRotation;
    }
}
