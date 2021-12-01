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
        //if (GetComponent<Move_CharUtama>() != null)
        //{
            if (FoodBar.mCurrentValue <= 300)
            {
                if (this.tag == "food1_algae")
                {
                    value = 4;
                    Destroy(gameObject);
                }
                if (this.tag == "food2_large_algae")
                {
                    value = 10;
                    Destroy(gameObject);
                }
                if (this.tag == "food5_bacteria")
                {
                    value = 8;
                    Destroy(gameObject);
                }
                if (this.tag == "food6_large_bacteria")
                {
                    value = 12;
                    Destroy(gameObject);
                }
                if (this.tag == "food7_gob")
                {
                    value = 20;
                    Destroy(gameObject);
                }
                if (this.tag == "food8_munch")
                {
                    value = 40;
                    Destroy(gameObject);
                }
                if (this.tag == "food9_mabomabo")
                {
                    value = 8;
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
        //}
    }

    IEnumerator CoralFood()
    {
        if (FoodBar.mCurrentValue <= 292)
        {
            yield return new WaitForSeconds(4);
            if (this.tag == "food3_coral")
            {
                FoodBar.mCurrentValue += 9;
            }
            if (this.tag == "food4_large_coral")
            {
                FoodBar.mCurrentValue += 17;
            }
            Destroy(gameObject);
        }
        else
        {
            FoodBar.mCurrentValue = 300;
        }
    }
}
