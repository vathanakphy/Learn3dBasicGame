using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f; // Movement force
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = false; // Allow natural rolling
    }

    void FixedUpdate()
    {
        // Get input
        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down

        // Calculate movement direction relative to world axes
        Vector3 move = new Vector3(moveX, 0, moveZ);

        // Apply force to the ball
        rb.AddForce(move * moveSpeed);
    }
}
