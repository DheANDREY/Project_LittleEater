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
    public GameObject playerCharacter;
    public GameObject evo100;
    public GameObject evo200;
    //public GameObject particleSystem;
    private Animator anim;

    void Start()
    {
        mCurrentValue = 0;
        mCurrentPercent = 0.0f;
        InvokeRepeating("DecreaseFood", 0, 2.0f);
    }

    void Update()
    {
        TxtFood.text = string.Format("{0}", Mathf.RoundToInt(mCurrentPercent * 300));
        ImgFoodbar.fillAmount = mCurrentPercent;
        if (mCurrentValue < 100)
        {
            playerCharacter.SetActive(true);
            evo100.SetActive(false);
            evo200.SetActive(false);
            //particleSystem.SetActive(false);
        }
        else if (mCurrentValue >= 100 && mCurrentValue <= 200)
        {
            playerCharacter.SetActive(false);
            evo100.SetActive(true);
            evo200.SetActive(false);
            //particleSystem.SetActive(true);
        }
        else if (mCurrentValue >= 200)
        {
            playerCharacter.SetActive(false);
            evo100.SetActive(false);
            evo200.SetActive(true);
            //particleSystem.SetActive(true);
        }
    }

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
