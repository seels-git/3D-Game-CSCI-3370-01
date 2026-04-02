using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCheckPoint : MonoBehaviour
{
    public GameObject marker;
    Vector3 spawnpoint;

    void Start()
    {
        spawnpoint = gameObject.transform.position;
    }

    void Update()
    {
        if(gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = spawnpoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CheckPoint"))
        {
            spawnpoint = marker.transform.position;
            Destroy(marker);
        }
    }
}
