using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Makanan : MonoBehaviour
{
    //public float moveSpeed = 5f;
    private Rigidbody2D rigidBody2D;
    public static int value = 0;
    
    public Animator[] anim;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();        
    }
    
    bool makan;
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     return;
    //     if(GetComponent<Move_CharUtama>() == null) { return; }

    //     // anim[0].SetTrigger("isMakan");
    //     // anim[1].SetTrigger("isMakan1");
    //     // anim[2].SetTrigger("isMakan2");
    //     //anim[0].SetBool("isEat", true);
    //     //if (GetComponent<Move_CharUtama>() != null)
    //     //{
    //     if (FoodBar.mCurrentValue <= 300)
    //         {            
    //             if (this.tag == "food1_algae")
    //             {
    //                 value = 4;
    //                 Destroy(gameObject);
    //             }
    //             if (this.tag == "food2_large_algae")
    //             {
    //                 value = 10;
    //                 Destroy(gameObject);
    //             }
    //             if (this.tag == "food5_bacteria")
    //             {
    //                 value = 8;
    //                 Destroy(gameObject);
    //             }
    //             if (this.tag == "food6_large_bacteria")
    //             {
    //                 value = 12;
    //                 Destroy(gameObject);
    //             }
    //             if (this.tag == "food7_gob")
    //             {
    //                 value = 20;
    //                 Destroy(gameObject);
    //             }
    //             if (this.tag == "food8_munch")
    //             {
    //                 value = 40;
    //                 Destroy(gameObject);
    //             }
    //             if (this.tag == "food9_mabomabo")
    //             {
    //                 value = 8;
    //                 Destroy(gameObject);
    //             }
    //             FoodBar.mCurrentValue += value;
    //             if (FoodBar.mCurrentValue >= 300)
    //                 FoodBar.mCurrentValue = 300;
    //             FoodBar.mCurrentPercent = (float)FoodBar.mCurrentValue / (float)(300);
    //         }
    //         else if (FoodBar.mCurrentValue >= 300)
    //         {
    //             FoodBar.mCurrentValue = 300;
    //         }
        
    // }

    public void Dimakan()
    {
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
    }
}
