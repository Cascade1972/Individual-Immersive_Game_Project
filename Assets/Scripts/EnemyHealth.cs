using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int EnemyHealthBar = 4;
    
    // Update is called once per frame
    void Update()
    {
        if (EnemyHealthBar <= 0)
        {
            Died();
        }
    }

    public void DamageTaken(int damage)
    {
        EnemyHealthBar -= damage;
    }

    private void Died()
    {
        Destroy(gameObject);
    }
}
