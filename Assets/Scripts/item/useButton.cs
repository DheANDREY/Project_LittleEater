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
        // FoodBar.instance.DecreaseFood(50);
        Food.instance.ekstra();
        Destroy(gameObject);
    
    }
    public GameObject freezeRadius;
    public GameObject charUtama;
    public void UseIce()
    {
        // ITEM BISA DITAMBAHKAN
        GameObject es = Instantiate(freezeRadius, new Vector3(charUtama.transform.position.x, charUtama.transform.position.y), Quaternion.identity) as GameObject;
       // es.transform.localScale = new Vector3(1, 1, 0);
        Destroy(gameObject);    
    }
    public void UseFood()
    {
        // ITEM BISA DITAMBAHKAN
        //HealthBarScript.instance.UpdateHealth(50);
       // GetComponent<Food>().ekstra();
        Destroy(gameObject);
    
    }
}
