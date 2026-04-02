using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement3D : MonoBehaviour
{   

    public float moveSpeed = 5f;
    private Rigidbody rb; 
    public float jumpspeed = 15f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
  float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal,0f,vertical) * moveSpeed;

        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
if (Input.GetKeyDown(KeyCode.Space))
        {
                rb.AddForce(Vector3.up*jumpspeed,ForceMode.Impulse);
        }
    }
}

