using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int EnemyHealthBar = 12;
    
    // Update is called once per frame
    void Update()
    {
        if (EnemyHealthBar <= 0)
        {
            //Debug.Log("Health 0");
            Died();
        }
    }

    public void DamageTaken(int damage)
    {
        //Debug.Log("Damage Taken " + damage);
        EnemyHealthBar -= damage;
    }

    private void Died()
    {
        //Debug.Log("Died");
        Destroy(gameObject);
    }
}
