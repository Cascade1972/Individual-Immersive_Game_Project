using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("Collision");
        if (collider.gameObject.tag == "Wasp")
        {
            //Debug.Log("Hit Enemy!!!");
            collider.gameObject.GetComponent<EnemyHealth>().DamageTaken(1);
            Destroy(gameObject);
        }
    }
}


/*using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage = 1;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Wasp"))
        {
            // Check if the player has a PowerUp script
            PowerUp powerUp = GetComponent<PowerUp>();
            if (powerUp != null)
            {
                // Apply the damage multiplier from the player's power-up
                bulletDamage *= powerUp.damageMultiplier;
            }

            // Deal damage to the enemy
            collider.gameObject.GetComponent<EnemyHealth>().DamageTaken(bulletDamage);
            Destroy(gameObject);
        }
        else if (collider.gameObject.CompareTag("PowerUp"))
        {
            // Check if the player has a PowerUp script
            PowerUp powerUp = GetComponent<PowerUp>();
            if (powerUp != null)
            {
                // Apply damage multiplier from the power-up
                powerUp.ApplyDamageMultiplier(2); // 2 times damage multiplier
                Destroy(collider.gameObject);
            }
        }
    }
}*/


