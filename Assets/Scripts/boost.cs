using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float boostedSpeed = 12f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.TryGetComponent(out PlayerMovement3D pm))
            {
                pm.setSpeed(boostedSpeed);
            }
        }
    }
}
