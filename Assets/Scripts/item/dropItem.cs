using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public GameObject[] randomItem;
    
    public void itemDrop()
    {
        Instantiate(randomItem[Random.Range(0, randomItem.Length)], transform.position, Quaternion.identity);
    }
}
