using UnityEngine;
using UnityEngine.InputSystem;


public class MovimientoPlaneta : MonoBehaviour
{
    public float velocidad = 10f;

    Rigidbody rb;
    Vector2 inputMovimiento;

    public Transform planeta;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMover(InputAction.CallbackContext context)
    {
        inputMovimiento = context.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        
        Vector3 haciaCentro = (transform.position - planeta.position).normalized;

        
        Vector3 derecha = Vector3.Cross(haciaCentro, transform.forward);


        Vector3 adelante = Vector3.Cross(derecha, haciaCentro);

        Vector3 direccion =
            adelante * inputMovimiento.y +
            derecha * inputMovimiento.x;

        rb.AddForce(direccion * velocidad, ForceMode.Acceleration);
    }
}