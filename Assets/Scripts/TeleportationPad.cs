using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TeleportationPad : MonoBehaviour
{
    public Transform teleportationArea;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport"))
        {
            other.transform.position = teleportationArea.position;
        }
    }
}
