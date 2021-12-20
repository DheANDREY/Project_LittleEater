using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useButton : MonoBehaviour
{
    public FoodBar foodB;
    private Inventory inventory;

    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        
    }

    public void UseHp()
    {
                // ITEM BISA DITAMBAHKAN
                HealthBarScript.instance.UpdateHealth(50);
                Destroy(gameObject);    
    }
    public void UseSlow()
    {
        // ITEM BISA DITAMBAHKAN
        FoodBar.instance.DecreaseFood(50);
        Destroy(gameObject);
    
    }
    public GameObject freezeRadius;
    public void UseIce()
    {
        // ITEM BISA DITAMBAHKAN
        
        Destroy(gameObject, 3);    
    }
    public void UseFood()
    {
        // ITEM BISA DITAMBAHKAN
        HealthBarScript.instance.UpdateHealth(50);
        Destroy(gameObject);
    
    }
}
