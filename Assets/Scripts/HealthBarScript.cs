using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    Image healthBar;
    float maxHealth = 100f;
    public static float health;
    public SoundController soC;
    public int _curentEvoIndex;
    

    public Renderer[] player;
    [SerializeField] private Color colorTo = Color.white;

    public static HealthBarScript instance;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
       // player = GetComponent<Renderer>();
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

    public void hpBerkurang(int nilai)
    {
        if(health - nilai >= 0)
        {
            health -= nilai;
            soC.hitDmg();

            // player.material.color = colorTo;
        }
        else
        {
            Debug.Log("HP Habis");
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        if (_curentEvoIndex != 1 && (FoodBar.mCurrentValue >= 100 && FoodBar.mCurrentValue < 200))
        {
            _curentEvoIndex = 1;
        }
        else if (_curentEvoIndex != 1 && (FoodBar.mCurrentValue >= 200 && FoodBar.mCurrentValue < 300))
        {
            _curentEvoIndex = 2;
        }
        else if (_curentEvoIndex != 0 && FoodBar.mCurrentValue < 100)
        {
            _curentEvoIndex = 0;
        }
    }

    private void changeColor()
    {
        player[_curentEvoIndex].material.color = colorTo;
    }
}