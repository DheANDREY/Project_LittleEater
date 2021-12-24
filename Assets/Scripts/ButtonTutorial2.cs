using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTutorial2 : MonoBehaviour
{
    public GameObject Eat;
    public GameObject Enemy;
    public GameObject Stun;
    public GameObject Evolution;

    //void Start()
    //{
        //Eat.SetActive(true);
    //}

    void OnMouseDown()
    {
        switch (this.gameObject.name)
        {
            case "Continue":
                Eat.SetActive(false);
                Enemy.SetActive(true);
                Stun.SetActive(false);
                Evolution.SetActive(false);
                break;
            case "Previous":
                Eat.SetActive(false);
                Enemy.SetActive(false);
                Stun.SetActive(false);
                Evolution.SetActive(true);
                break;
            case "Continue2":
                Eat.SetActive(false);
                Enemy.SetActive(false);
                Stun.SetActive(true);
                Evolution.SetActive(false);
                break;
            case "Previous2":
                Eat.SetActive(true);
                Enemy.SetActive(false);
                Stun.SetActive(false);
                Evolution.SetActive(false);
                break;
            case "Continue3":
                Eat.SetActive(false);
                Enemy.SetActive(false);
                Stun.SetActive(false);
                Evolution.SetActive(true);
                break;
            case "Previous3":
                Eat.SetActive(false);
                Enemy.SetActive(true);
                Stun.SetActive(false);
                Evolution.SetActive(false);
                break;
            case "Continue4":
                Eat.SetActive(true);
                Enemy.SetActive(false);
                Stun.SetActive(false);
                Evolution.SetActive(false);
                break;
            case "Previous4":
                Eat.SetActive(false);
                Enemy.SetActive(false);
                Stun.SetActive(true);
                Evolution.SetActive(false);
                break;
        }
    }
}
