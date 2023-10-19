using UnityEngine;

public class automove : MonoBehaviour
{
    public float speed = 30.0f; // Velocidad de movimiento en el eje Z

    void Update()
    {
        // Mueve el GameObject a lo largo del eje Z
        transform.Translate(Vector3.down  * speed * Time.deltaTime);
    }
}
