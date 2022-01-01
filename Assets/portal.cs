using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class portal : MonoBehaviour
{
    public GameObject player;
    private GameObject portalMenu;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        portalMenu = GameObject.Find("MenuPortal");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Move_CharUtama>() != null)
        {
            _menuPortal();
        }
    }

    public void _menuPortal()
    {
        portalMenu.SetActive(true);

        Time.timeScale = 0f;
        pause.isGamePaused = true;
    }

    public void noPortal()
    {
        portalMenu.SetActive(false);

        Time.timeScale = 1f;
        pause.isGamePaused = false;
    }
}
