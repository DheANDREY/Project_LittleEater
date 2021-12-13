using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    private void Start()
    {
        inventory = GetComponent<Inventory>();
    }
    private void Update()
    {
        itemSlot();
    }

    void itemSlot()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false){
                // ITEM BISA DITAMBAHKAN
                inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                break;
                }
            }
        }
    }
}
