using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public GameObject On;
    public GameObject Off;
    //public GameObject BGMSet;
    //private MainMenuBGM Menu;
    //private
    GameObject BGM;

    public void Start()
    {
        BGM = FindObjectOfType<MainMenuBGM>().gameObject;
        //BGMSet = BGM;
        //Destroy(BGM);
    }

    public void OnMouseDown()
    {
        switch (this.gameObject.name)
        {
            case "OnButton":
                Off.SetActive(true);
                On.SetActive(false);
                //BGM.SetActive(true);
                gameObject.GetComponent<MainMenuBGM>().enabled = true;
                break;
            case "OffButton":
                Off.SetActive(false);
                On.SetActive(true);
                gameObject.GetComponent<MainMenuBGM>().enabled = false;
                //Destroy(BGM);
                //Menu.OffBGM();
                //BGM.SetActive(false);
                break;
        }
    }
}
