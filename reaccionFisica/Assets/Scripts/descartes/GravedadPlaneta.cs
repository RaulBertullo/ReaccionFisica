using UnityEngine;

public class GravedadPlaneta : MonoBehaviour
{
    public Transform planeta;
    public float fuerzaGravedad = 30f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // quito gravedad normal
    }

    void FixedUpdate()
    {
        // la dirección va hacia el centro del planeta
        Vector3 direccion = (planeta.position - transform.position).normalized;

        // con esto aplico fuerza hacia el planeta
        rb.AddForce(direccion * fuerzaGravedad, ForceMode.Acceleration);
    }
}
