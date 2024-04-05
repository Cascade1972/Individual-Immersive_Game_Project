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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Wasp")
        {
            Debug.Log("Hit Enemy!!!");
            collision.gameObject.GetComponent<EnemyHealth>().DamageTaken(1);
            Destroy(gameObject);
        }
    }
}
