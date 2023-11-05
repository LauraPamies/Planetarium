using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeNave : MonoBehaviour
{
    public float velocidadRotacion = 100.0f;
    public float velocidadAvance = 5.0f;

    private float rotacionY = 0.0f;

    void Update()
    {
        // Control de rotación con el ratón
        float rotacionX = Input.GetAxis("Mouse Y") * velocidadRotacion * Time.deltaTime;
        rotacionY += Input.GetAxis("Mouse X") * velocidadRotacion * Time.deltaTime;

        // Aplicar la rotación a la nave
        transform.rotation *= Quaternion.Euler(-rotacionX, rotacionY, 0.0f);

        // Control de movimiento hacia adelante y hacia atrás con las teclas "W" y "S"
        float movimientoVertical = Input.GetAxis("Vertical");

        // Aplicar el movimiento hacia adelante (forward)
        transform.Translate(Vector3.forward * movimientoVertical * velocidadAvance * Time.deltaTime, Space.Self);
    }
}
