using UnityEngine;

public class key_and_wall : MonoBehaviour
{
    public GameObject key;

    public GameObject wall;
    
     private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(key);

            Destroy(wall);
        }
    }
    
}
