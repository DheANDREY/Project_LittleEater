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
        isGenBoost = true;
        Destroy(gameObject);
        StartCoroutine(durasi());
    }
    private IEnumerator durasi()
    {
        yield return new WaitForSeconds(3);
        isGenBoost = false;
    }


}
