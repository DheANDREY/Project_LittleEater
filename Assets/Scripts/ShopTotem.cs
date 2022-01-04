using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTotem : MonoBehaviour
{
    private GameObject player;
    [SerializeField] GameObject shopMenu;
    public GameObject buttonHandler;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        shopMenu = FindObjectOfType<cameraFollow>().ShopMenu;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Move_CharUtama>() != null)
        {
            ShopMenu();
        }
    }

    public void ShopMenu()
    {
        shopMenu.SetActive(true);
        buttonHandler.SetActive(false);
        Time.timeScale = 0f;
        pause.isGamePaused = true;
    }

    public void exitShop()
    {
        shopMenu.SetActive(false);
        buttonHandler.SetActive(true);
        Time.timeScale = 1f;
        pause.isGamePaused = false;
    }
}
