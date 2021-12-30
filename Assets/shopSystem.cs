using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopSystem : MonoBehaviour
{
    public Inventory inventory;
    public GameObject[] itemButton;
    public Move_CharUtama mcu;
    public void buyFood(int harga)
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false && mcu.score > harga)
            {
                // ITEM BISA DITAMBAHKAN
                inventory.isFull[i] = true;
                mcu.score -= harga;
                Instantiate(itemButton[0], inventory.slots[i].transform, false);                
                break;
            }
        }
    }
    public void buyHP(int harga)
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false && mcu.score > harga)
            {
                // ITEM BISA DITAMBAHKAN
                inventory.isFull[i] = true;
                mcu.score -= harga;
                Instantiate(itemButton[1], inventory.slots[i].transform, false);
                break;
            }
        }
    }
    public void buyRapid(int harga)
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false && mcu.score > harga)
            {
                // ITEM BISA DITAMBAHKAN
                inventory.isFull[i] = true;
                mcu.score -= harga;
                Instantiate(itemButton[2], inventory.slots[i].transform, false);
                break;
            }
        }
    }
    public void buyGen(int harga)
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false && mcu.score > harga)
            {
                // ITEM BISA DITAMBAHKAN
                inventory.isFull[i] = true;
                mcu.score -= harga;
                Instantiate(itemButton[3], inventory.slots[i].transform, false);
                break;
            }
        }
    }
}
