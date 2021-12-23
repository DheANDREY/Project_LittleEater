using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useButton : MonoBehaviour
{
    public FoodBar foodB;
    private Inventory inventory;

    private Transform player;
    private float timer = 3;
    public bool isFoodBuff = false;
    public bool isGenBoost;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }
    public static useButton instance;
    private void Awake()
    {
        instance = this;
    }


    public void UseSlow()
    {
        isFoodBuff = true;
        Move_CharUtama.instance.isFoodUp = true;
        Destroy(gameObject);
        StartCoroutine(delay());
    }

    private IEnumerator delay()
    {       
        yield return new WaitForSeconds(3);
        isFoodBuff = false;
    }
    
    public void UseHp()
    {        
        HealthBarScript.instance.UpdateHealth(50);
        Move_CharUtama.instance.isHeal = true;
        Destroy(gameObject);        
    }
    
    public void UseIce()
    {
        Move_CharUtama.instance.isIceSpawn = true;
        Destroy(gameObject);    
    }
    public void UseFood()
    {
        isGenBoost = true;
        Move_CharUtama.instance.isGenUp = true;
        Destroy(gameObject);
        StartCoroutine(durasi());
    }
    private IEnumerator durasi()
    {
        yield return new WaitForSeconds(3);
        isGenBoost = false;
    }


}
