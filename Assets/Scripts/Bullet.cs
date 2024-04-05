using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        //if (collision.gameObject.name == "Enemy")
        //{
            Destroy(collision.gameObject);
            Destroy(gameObject);
        //}
    }
}
