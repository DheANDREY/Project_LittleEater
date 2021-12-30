using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTotem : MonoBehaviour
{
    public GameObject player;
    [SerializeField] GameObject shopMenu;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
        Time.timeScale = 0f;
        pause.isGamePaused = true;
    }

    public void exitShop()
    {
        shopMenu.SetActive(false);
        Time.timeScale = 1f;
        pause.isGamePaused = false;
    }
}
