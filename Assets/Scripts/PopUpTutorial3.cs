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
        StartCoroutine("PopUpFoodBar");
        StartCoroutine("PopUpDashBar");
        //StartCoroutine("PopUpPowerUp");
        //StartCoroutine("PopUpPause");
        StartCoroutine("PopUpPlay");
    }
    
    IEnumerator PopUpFoodBar()
    {
        yield return new WaitForSeconds(3);
        HP.SetActive(false);
        FoodBar.SetActive(true);
        DashBar.SetActive(false);
        PowerUp.SetActive(false);
        Pause.SetActive(false);
    }

    IEnumerator PopUpDashBar()
    {
        yield return new WaitForSeconds(6);
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(true);
        PowerUp.SetActive(false);
        Pause.SetActive(false);
    }

    /*IEnumerator PopUpPowerUp()
    {
        yield return new WaitForSeconds(9);
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerUp.SetActive(true);
        Pause.SetActive(false);
    }

    IEnumerator PopUpPause()
    {
        yield return new WaitForSeconds(12);
        HP.SetActive(false);
        FoodBar.SetActive(false);
        DashBar.SetActive(false);
        PowerUp.SetActive(false);
        Pause.SetActive(true);
    }*/

    IEnumerator PopUpPlay()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene("CharacterMove");
    }
}
