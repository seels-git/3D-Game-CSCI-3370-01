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
        if (gameObject.transform.position.y < 3f)
        {
            Die();
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

    void Die()
    {
        UIManager.Instance.ShowGameOver();
        gameObject.SetActive(false);
    }
}