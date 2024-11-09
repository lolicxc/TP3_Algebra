using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ModelController : MonoBehaviour
{
    public GameObject model;

    void Update()
    {
        // Control de movimiento, rotación y escala
        float moveSpeed = 5f;
        float rotateSpeed = 100f;
        float scaleSpeed = 0.1f;

        // Movimiento
        model.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Rotación
        model.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        // Escala
        if (Input.GetKey(KeyCode.UpArrow)) model.transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow)) model.transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }
}
