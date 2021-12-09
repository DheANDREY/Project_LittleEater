using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    Image healthBar;
    float maxHealth = 100f;
    public static float health;

    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    public void UpdateHealth(float mod)
    {
        health += mod;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f)
        {
            health = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
    }
}