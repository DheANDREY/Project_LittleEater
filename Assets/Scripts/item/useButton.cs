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
    public bool isGenBoost = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }
    public static useButton instance;
    private void Awake()
    {
        instance = this;
    }
    
    public void UseFood2x()
    {
        isFoodBuff = true;
        Move_CharUtama.instance.isFoodUp = true;        
        StartCoroutine(delay());
        Destroy(gameObject);
    }

    private IEnumerator delay()
    {
        yield return new WaitForSeconds(5);
        isFoodBuff = false;
    }
    public void UseHp()
    {        
        HealthBarScript.instance.UpdateHealth(50);
        Move_CharUtama.instance.isHeal = true;
        Destroy(gameObject);        
    }
    
    public void UseBite()
    {
        Move_CharUtama.instance.isIceSpawn = true;
        Destroy(gameObject);    
    }
    public void UseGen()
    {
        isGenBoost = true;
        Move_CharUtama.instance.isGenUp = true;        
        StartCoroutine(durasi());
        Destroy(gameObject);

    }
    private IEnumerator durasi()
    {   
        yield return new WaitForSeconds(5);
        isGenBoost = false;
    }


}
