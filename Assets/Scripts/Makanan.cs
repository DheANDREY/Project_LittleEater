using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Makanan : MonoBehaviour
{
    //public float moveSpeed = 5f;
    private Rigidbody2D rigidBody2D;
    public static int value = 0;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();        
    }    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (FoodBar.mCurrentValue <= 300)
        {
            if (this.tag == "food1_algae")
            {
                value = 4;
                Destroy(gameObject);
            }
            if (this.tag == "food3_coral")
            {
                //FoodBar.mCurrentValue +=2;
                StartCoroutine(CoralFood());
            }
            /*if (this.tag == "food5_bacteria")
            {
                value = 8;
                Destroy(gameObject);
            }*/
            if (this.tag == "food7_gob")
            {
                value = 50;
                Destroy(gameObject);
            }
            if (this.tag == "food8_munch")
            {
                value = 70;
                Destroy(gameObject);
            }
            if (this.tag == "food9_mabomabo")
            {
                value = 100;
                Destroy(gameObject);
            }
            FoodBar.mCurrentValue += value;
            if (FoodBar.mCurrentValue >= 300)
                FoodBar.mCurrentValue = 300;
            FoodBar.mCurrentPercent = (float)FoodBar.mCurrentValue / (float)(300);
        }
        else if (FoodBar.mCurrentValue >= 300)
        {
            FoodBar.mCurrentValue = 300;
        }
    }

    IEnumerator CoralFood()
    {
        if (FoodBar.mCurrentValue <= 292)
        {
            yield return new WaitForSeconds(4);
            FoodBar.mCurrentValue += 9;
            Destroy(gameObject);
        }
        else
        {
            FoodBar.mCurrentValue = 300;
        }
    }
}
