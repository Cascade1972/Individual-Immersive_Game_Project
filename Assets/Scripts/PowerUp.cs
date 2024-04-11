using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private int baseDamage = 1; // Initial damage value
    public int damageMultiplier = 2; // Default multiplier

    public void ApplyDamageMultiplier(int multiplier)
    {
        damageMultiplier = multiplier;
        Debug.Log("Damage multiplier applied: " + damageMultiplier);
    }

    public void DealDamage(GameObject target)
    {
        int totalDamage = baseDamage * damageMultiplier;
        Debug.Log("Dealing " + totalDamage + " damage to " + target.name);
        EnemyHealth enemyHealth = target.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DamageTaken(totalDamage);
        }
        else
        {
            Debug.LogWarning("EnemyHealth script not found on the target!");
        }
    }
}
