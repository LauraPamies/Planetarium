using UnityEngine;

public class automove : MonoBehaviour
{
    public float speed = 1.0f; // Velocidad de movimiento en el eje Z

    void Update()
    {
        // Mueve el GameObject a lo largo del eje Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
