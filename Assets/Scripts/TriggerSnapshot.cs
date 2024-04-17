using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TriggerSnapshot : MonoBehaviour
{
    //public AudioMixerSnapshot baseSnapshot
    public AudioMixerSnapshot newSnapshot; // The new snapshot to transition to
    public float transitionTime = 1.0f; // The time it should take to transition

    private void OnTriggerEnter(Collider other)
    {
        // When the trigger happens, transition to the new snapshot
        newSnapshot.TransitionTo(transitionTime);
    }

    /*public void OnTriggerExit(Collider other)
    {
        baseSnapshot.TransitionTo(transitionTime);
    }*/
}
