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
        //foodB.DecreaseFood(1/2);
        Destroy(gameObject);
    }
}
