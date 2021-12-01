using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
    public Image ImgFoodbar;
    public Text TxtFood;
    public static int mCurrentValue;
    public static float mCurrentPercent;
    public GameObject player;
    public GameObject beforeEvo;
    public GameObject evo100;
    public GameObject evo200;
    private Animator anim;
    //private bool _isReached300;

    void Start()
    {
        mCurrentPercent = 0.0f;
        mCurrentValue = 50;
        InvokeRepeating("DecreaseFood", 0, 1.0f);
    }

    void Update()
    {
        TxtFood.text = string.Format("{0}", Mathf.RoundToInt(mCurrentPercent * 300));
        ImgFoodbar.fillAmount = mCurrentPercent;
        if (mCurrentValue < 100)
        {
            beforeEvo.SetActive(true);
            evo100.SetActive(false);
            evo200.SetActive(false);
        }
        else if (mCurrentValue >= 100 && mCurrentValue <= 200)
        {
            beforeEvo.SetActive(false);
            evo100.SetActive(true);
            evo200.SetActive(false);
        }
        else if (mCurrentValue >= 200)
        {
            beforeEvo.SetActive(false);
            evo100.SetActive(false);
            evo200.SetActive(true);
        }
        if (mCurrentValue == 0)
        {
            player.SetActive(false);
        }

        /*if (_isReached300)
        {
            DecreaseFood(1);
        }
        else
        {
            DecreaseFood(5);
        }*/
    }

    /*private void IncreaseFood(int value)
    {
        mCurrentValue += value;
        if(mCurrentValue >= 300)
        {
            _isReached300 = true;
        }
        UpdateBar();
    }

    private void DecreaseFood(int value)
    {
        mCurrentValue -= value;
        if (mCurrentValue < 0)
            mCurrentValue = 0;
        UpdateBar();
    }

    private void UpdateBar()
    {
        mCurrentPercent = (float)mCurrentValue / (float)(300);
        TxtFood.text = string.Format("{0}", Mathf.RoundToInt(mCurrentPercent * 300));
        ImgFoodbar.fillAmount = mCurrentPercent;
    }*/

    public void DecreaseFood()
    {
        mCurrentValue--;
        if (mCurrentValue < 0)
            mCurrentValue = 0;
        mCurrentPercent = (float)mCurrentValue / (float)(300);
        TxtFood.text = string.Format("{0}", Mathf.RoundToInt(mCurrentPercent * 300));
        ImgFoodbar.fillAmount = mCurrentPercent;    
    }
}
