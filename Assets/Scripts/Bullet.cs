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
        Debug.Log("Collision");
        if (collider.gameObject.tag == "Wasp")
        {
            //Debug.Log("Hit Enemy!!!");
            collider.gameObject.GetComponent<EnemyHealth>().DamageTaken(1);
            Destroy(gameObject);
        }
    }
}
