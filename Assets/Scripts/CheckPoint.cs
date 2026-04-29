using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public BoxCollider trigger;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Respawn.Instance.respawnPoint = transform;
            trigger.enabled = false;
        }
    }
}