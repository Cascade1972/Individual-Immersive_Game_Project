using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TeleportTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioSource audio;
    
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport"))
        {
            audio.Play();
        }
    }
}
