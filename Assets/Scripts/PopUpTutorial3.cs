using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopUpTutorial3 : MonoBehaviour
{
    public GameObject HP;
    public GameObject FoodBar;
    public GameObject DashBar;
    public GameObject PowerUp;
    public GameObject Pause;

    public void Start()
    {
        Invoke("PopUpFoodBar", 2.5f);
        Invoke("PopUpDashBar", 5.0f);
        Invoke("PopUpPowerUp", 7.5f);
        Invoke("PopUpPause", 10.0f);
        Invoke("PopUpPlay", 12.5f);
    }
    
    public void PopUpFoodBar()
    {
        HP.SetActive(false);
        FoodBar.SetActive(true);
        DashBar.SetActive(false);
        PowerUp.SetActive(false);
        Pause.SetActive(false);
    }

    public void PopUpDashBar()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(true);
        PowerUp.SetActive(false);
        Pause.SetActive(false);
    }

    public void PopUpPowerUp()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerUp.SetActive(true);
        Pause.SetActive(false);
    }

    public void PopUpPause()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerUp.SetActive(false);
        Pause.SetActive(true);
    }

    public void PopUpPlay()
    {
        SceneManager.LoadScene("CharacterMove");
    }
}
