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
    public GameObject PowerSlot;
    public GameObject Pause;
    public GameObject GenBonus;
    public GameObject FoodBonus;
    public GameObject CrystalHealth;
    public GameObject IceCube;
    public GameObject Encyclopedia;
    public GameObject Galleries;

    public void Start()
    {
        Invoke("PopUpFoodBar", 2.5f);
        Invoke("PopUpDashBar", 5.0f);
        Invoke("PopUpPowerSlot", 7.5f);
        Invoke("PopUpGenBonus", 10.0f);
        Invoke("PopUpCrystalHealth", 12.5f);
        Invoke("PopUpFoodBonus", 15.0f);
        Invoke("PopUpIceCube", 17.5f);
        Invoke("PopUpGalleries", 20.0f);
        Invoke("PopUpEncyclopedia", 22.5f);
        Invoke("PopUpPause", 25.0f);
        Invoke("PopUpPlay", 27.5f);
    }
    
    public void PopUpFoodBar()
    {
        HP.SetActive(false);
        FoodBar.SetActive(true);
        DashBar.SetActive(false);
        PowerSlot.SetActive(false);
        GenBonus.SetActive(false);
        FoodBonus.SetActive(false);
        CrystalHealth.SetActive(false);
        IceCube.SetActive(false);
        Pause.SetActive(false);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(false);
    }

    public void PopUpDashBar()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(true);
        PowerSlot.SetActive(false);
        GenBonus.SetActive(false);
        FoodBonus.SetActive(false);
        CrystalHealth.SetActive(false);
        IceCube.SetActive(false);
        Pause.SetActive(false);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(false);
    }

    public void PopUpPowerSlot()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerSlot.SetActive(true);
        GenBonus.SetActive(false);
        FoodBonus.SetActive(false);
        CrystalHealth.SetActive(false);
        IceCube.SetActive(false);
        Pause.SetActive(false);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(false);
    }

    public void PopUpGenBonus()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerSlot.SetActive(false);
        GenBonus.SetActive(true);
        FoodBonus.SetActive(false);
        CrystalHealth.SetActive(false);
        IceCube.SetActive(false);
        Pause.SetActive(false);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(false);
    }

    public void PopUpFoodBonus()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerSlot.SetActive(false);
        GenBonus.SetActive(false);
        FoodBonus.SetActive(true);
        CrystalHealth.SetActive(false);
        IceCube.SetActive(false);
        Pause.SetActive(false);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(false);
    }

    public void PopUpCrystalHealth()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerSlot.SetActive(false);
        GenBonus.SetActive(false);
        FoodBonus.SetActive(false);
        CrystalHealth.SetActive(true);
        IceCube.SetActive(false);
        Pause.SetActive(false);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(false);
    }

    public void PopUpIceCube()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerSlot.SetActive(false);
        GenBonus.SetActive(false);
        FoodBonus.SetActive(false);
        CrystalHealth.SetActive(false);
        IceCube.SetActive(true);
        Pause.SetActive(false);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(false);
    }

    public void PopUpGalleries()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerSlot.SetActive(false);
        GenBonus.SetActive(false);
        FoodBonus.SetActive(false);
        CrystalHealth.SetActive(false);
        IceCube.SetActive(false);
        Pause.SetActive(false);
        Galleries.SetActive(true);
        Encyclopedia.SetActive(false);
    }

    public void PopUpEncyclopedia()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerSlot.SetActive(false);
        GenBonus.SetActive(false);
        FoodBonus.SetActive(false);
        CrystalHealth.SetActive(false);
        IceCube.SetActive(false);
        Pause.SetActive(false);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(true);
    }

    public void PopUpPause()
    {
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerSlot.SetActive(false);
        Pause.SetActive(true);
        Galleries.SetActive(false);
        Encyclopedia.SetActive(false);
    }

    public void PopUpPlay()
    {
        SceneManager.LoadScene("CharacterMove");
    }
}
