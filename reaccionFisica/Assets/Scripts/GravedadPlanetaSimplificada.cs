using UnityEngine;

public class GravedadPlanetaSimplificada : MonoBehaviour
{
    public Transform planeta;
    public float fuerzaGravedad = 30f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; 
    }

    void FixedUpdate()
    {
        
        Vector3 direccion = (planeta.position - transform.position).normalized;

        
        rb.AddForce(direccion * fuerzaGravedad, ForceMode.Acceleration);
    }
}
