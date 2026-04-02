using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    
    [SerializeField] GameObject Player;

    [SerializeField] Transform spawnPoint;

void OnTriggerEnter(Collider other)
    {
      RespawnPoint();
    }
void RespawnPoint()
    {
        Player.transform.position = spawnPoint.transform.position;
    }
 }