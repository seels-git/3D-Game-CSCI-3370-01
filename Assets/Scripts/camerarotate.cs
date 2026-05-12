using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float sensitivity = 200f;
    public Transform target;
    public float distance = 5f;

    float rotX;
    float rotY;

    void Update()
    {
        // Only rotate when holding LEFT CLICK
        if (Input.GetMouseButton(0))
        {
            rotX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            rotY -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
            rotY = Mathf.Clamp(rotY, -30f, 60f);
        }

        Quaternion rotation = Quaternion.Euler(rotY, rotX, 0);
        Vector3 offset = rotation * new Vector3(0, 0, -distance);

        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
