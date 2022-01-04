using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class portal : MonoBehaviour
{
    private GameObject player;
    private GameObject portalMenuController;
    public static bool isGamePaused = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        portalMenuController = FindObjectOfType<cameraFollow>().PortalMenu;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO: check objective udah clear apa belum
        if(true)
        {
            if (collision.GetComponent<Move_CharUtama>() != null)
            {
                if (isGamePaused)
                {
                    noPortal();
                }
                else
                {
                    _menuPortal();
                }
            }
        }
        else
        {
            // TODO: ga bisa masuk portal karena  ada objective yg belum kelar
        }
    }

    public void _menuPortal()
    {
        portalMenuController.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void noPortal()
    {
        portalMenuController.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
}
