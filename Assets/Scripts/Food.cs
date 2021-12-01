using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    [SerializeField] private int _valueMakanan;    
    private Rigidbody2D rigidBody2D;
    public static int value = 0;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        //_valueMakanan = 50;
    }    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (GetComponent<Move_CharUtama>() != null)
        //{
            FoodBar.mCurrentValue += _valueMakanan;
            if (FoodBar.mCurrentValue >= 300)
                FoodBar.mCurrentValue = 300;
            //FoodBar.mCurrentValue = (int)Mathf.Min(FoodBar.mCurrentValue + _valueMakanan, 300);
            FoodBar.mCurrentPercent = (float)FoodBar.mCurrentValue / (float)(300);
            Destroy(gameObject);
        //}
    }

    /*IEnumerator CoralFood()
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
    }*/
}
