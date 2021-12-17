using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFood : MonoBehaviour
{
    public FoodBar foodB;

    private Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        Fillbar.instance.kurang(-20);
        Debug.Log(FoodBar.mCurrentValue);
        Destroy(gameObject);
    }
}
