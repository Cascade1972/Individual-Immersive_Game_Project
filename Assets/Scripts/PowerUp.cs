using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int baseDamage = 2; // Initial damage value
    public bool powerUpActive = false;

    void Update()
    {
        if (powerUpActive)
        {
            baseDamage = 4;
        }
        else
        {
            baseDamage = 2;
        }

    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Triggered");
        if (collider.gameObject.CompareTag("PowerUp"))
        {
            Debug.Log("Destroyed");
            Destroy(collider.gameObject);
            StartCoroutine(PowerUpTimer());
        }
    }

    public IEnumerator PowerUpTimer()
    {
        // Set powerUpActive to true
        powerUpActive = true;

        // Wait for 5 seconds
        yield return new WaitForSeconds(5);

        // Set powerUpActive back to false
        powerUpActive = false;
    }
}
