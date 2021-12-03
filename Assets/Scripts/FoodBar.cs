﻿using System.Collections;
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
    public Animator[] anim;
    private bool _isReached300;

    void Start()
    {
        mCurrentPercent = 0.0f;
        mCurrentValue = 50;
        InvokeRepeating("Cek300", 0, 1.0f);
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
    }

    private void IncreaseFood(int value)
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
    }

    private void Cek300()
    {
        if (mCurrentValue >= 300)
        {
            _isReached300 = true;
            DecreaseFood(1);
        }
        if (_isReached300)
        {
            DecreaseFood(1);
        }
        else
        {
            DecreaseFood(2);
        }
    }
}
