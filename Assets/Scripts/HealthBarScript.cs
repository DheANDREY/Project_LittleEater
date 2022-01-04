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

    public Renderer[] player;
    [SerializeField] private Color colorTo = Color.white;

    public static HealthBarScript instance;
    public GameObject _gameOverP;
    public GameObject buttonHandler;
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
    //public Move_CharUtama mcu;
    public bool mati;
    public void hpBerkurang(int nilai)
    {
        if(health - nilai >= 0)
        {
            health -= nilai;
            soC.hitDmg();
            if(health <= 0)
            {
                mati = true;
            }
            
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
        Debug.Log(health);
        healthBar.fillAmount = health / maxHealth;
        if(health <= 0)
        {
            _gameOverP.SetActive(true);
            buttonHandler.SetActive(false);
        }
    }
}