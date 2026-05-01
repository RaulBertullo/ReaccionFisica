using UnityEngine;
using UnityEngine.InputSystem;

public class CoheteFuerza : MonoBehaviour
{
    Rigidbody rb;
    public float fuerzaEmpuje = 300000f;

    bool motorEncendido = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnDespegar(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            motorEncendido = true;
            Debug.Log("despegue");
        }
    }

    void FixedUpdate()
    {
        if (motorEncendido)
        {
            rb.AddForce(Vector3.up * fuerzaEmpuje);
        }
    }
}