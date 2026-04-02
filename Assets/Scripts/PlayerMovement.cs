using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f; // Added for turning speed

    public float jumpspeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 1. Handle Rotation (Left/Right)
        // This rotates the character on the Y-axis based on horizontal input
        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);

        // 2. Handle Forward Movement (Up/Down)
        // We move in the direction the character is CURRENTLY facing (transform.forward)
        Vector3 moveDirection = transform.forward * vertical * moveSpeed;

        // 3. Apply to Rigidbody
        // We keep rb.linearVelocity.y so the character can still fall with gravity
        rb.linearVelocity = new Vector3(moveDirection.x, rb.linearVelocity.y, moveDirection.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
                rb.AddForce(Vector3.up*jumpspeed,ForceMode.Impulse);
        }
    }
}