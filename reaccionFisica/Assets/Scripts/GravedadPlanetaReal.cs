using UnityEngine;

public class GravedadPlanetaReal : MonoBehaviour
{
    public Transform planeta;
    public float fuerzaGravedad = 30f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // quitamos gravedad de Unity
    }

    void FixedUpdate()
    {
        // dirección hacia el centro del planeta
        Vector3 direccion = (planeta.position - transform.position).normalized;

        // gravedad REAL (la masa del jugador SÍ influye)
        rb.AddForce(direccion * fuerzaGravedad, ForceMode.Force);
    }
}
