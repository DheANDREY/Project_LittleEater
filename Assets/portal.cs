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
    public static portal instance;
    private void Awake()
    {
        instance = this;
    }

    public bool isNotifSpawn = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO: check objective udah clear apa belum
        if(collision.GetComponent<Move_CharUtama>() != null && Move_CharUtama.instance.score >= 250)
        {
           // if (collision.GetComponent<Move_CharUtama>() != null)
            //{
                _menuPortal();                
            //}
        }
        else
        {
            // TODO: ga bisa masuk portal karena  ada objective yg belum kelar
            isNotifSpawn = true;
        }
    }

    public void _menuPortal(bool r = true)
    {
        portalMenuController.SetActive(r);
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
