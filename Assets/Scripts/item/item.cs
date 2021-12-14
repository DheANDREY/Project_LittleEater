﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    // ITEM BISA DITAMBAHKAN
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    //GameObject fxE = Instantiate(itemButton, inventory.slots[i].transform, false) as GameObject;
                    itemButton.transform.SetParent(transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
