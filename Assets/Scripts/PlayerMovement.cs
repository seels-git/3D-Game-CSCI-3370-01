using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public float jumpForce = 7f;

    private Rigidbody rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // --- ROTATION (Left/Right) ---
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0f, horizontal * rotationSpeed * Time.deltaTime, 0f);

        // --- FORWARD MOVEMENT (Forward/Backward) ---
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.forward * vertical * moveSpeed;

        // Keep gravity by preserving rb.velocity.y
        rb.linearVelocity = new Vector3(moveDirection.x, rb.linearVelocity.y, moveDirection.z);

        // --- JUMP ---
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // Detect ground contact
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}