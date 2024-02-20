using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float detectionRange = 10f;

    private Transform player;

    void Start()
    {
        // Find the player using the tag
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        // Check if the player is within the detection range
        if (Vector3.Distance(transform.position, player.position) <= detectionRange)
        {
            // Calculate the direction to the player
            Vector3 direction = (player.position - transform.position).normalized;

            // Move towards the player
            transform.Translate(direction * movementSpeed * Time.deltaTime);
        }
    }
}
