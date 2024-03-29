using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private float MaxHealthBarLength = 1.0f;
    private float MaxPlayerHealth;
    private float CurrentPlayerHealth;
    private float HealthPercentage;
    private float CurrentHealthBarLength;

    private RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();
        MaxPlayerHealth = transform.parent.parent.GetComponent<PlayerDeath>().PlayerHealth;
        GetComponent<Image>().color = Color.green;
    }

    // Update is called once per frame
    public void ChangeHealth(float EnemyHealth)
    {
        CurrentPlayerHealth = EnemyHealth;
        HealthPercentage = CurrentPlayerHealth / MaxPlayerHealth;
        CurrentHealthBarLength = MaxHealthBarLength * HealthPercentage;
        rt.sizeDelta = new Vector2(CurrentHealthBarLength, rt.sizeDelta.y);
        ImageHealthColor();
    }

    private void ImageHealthColor()
    {
        if (CurrentPlayerHealth > 14)
        {
            GetComponent<Image>().color = Color.green;
        }
        else if (CurrentPlayerHealth > 7)
        {
            GetComponent<Image>().color = Color.yellow;
        }
        else
        {
            GetComponent<Image>().color = Color.red;
        }
    }
}
