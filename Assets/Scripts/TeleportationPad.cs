using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TeleportationPad : MonoBehaviour
{
    public Transform teleportationArea;
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touching");
        if (other.CompareTag("Teleport"))
        {
            Debug.Log("Teleporting");
            other.transform.position = teleportationArea.position;
        }
    }
}
