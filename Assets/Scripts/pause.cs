using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject shop;
    public GameObject shopExit;
    public GameObject buttonHandler;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject GalleryM;
    [SerializeField] GameObject _EncyMenu;
    [SerializeField] GameObject BGMobjek;    [SerializeField] GameObject sfxMobjek;
    [SerializeField] GameObject xBGM;        [SerializeField]GameObject xSfx;
    [SerializeField] GameObject OBGM;        [SerializeField] GameObject OSfx;
    public GameObject Bsong;

    public bool isBGMOn = true;
    public bool isSfxOn = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (isBGMOn)
        {
             bgmOn();
        }
        else
        {
            bgmOff();
        }

        if (isSfxOn)
        {
            sfxOn();
        }
        else
        {
            sfxOff();
        }

    }
    public void buttonPause()
    {
        if (isGamePaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }
    public void buttonGallery()
    {
        if (isGamePaused)
        {
            exitGallery();
        }
        else
        {
            GalleryMenu();
        }
    }
    public void buttonEncy()
    {
        if (isGamePaused)
        {
            exitEncy();
        }
        else
        {
            EncyMenu();
        }
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        buttonHandler.SetActive(true);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        buttonHandler.SetActive(false);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    
    public void RestartMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void RestartMenu1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        if (FindObjectOfType<MainMenuBGM>().gameObject != null)
        {
            DestroyImmediate(FindObjectOfType<MainMenuBGM>().gameObject);
        }
        SceneManager.LoadScene("MainMenu");
    }
    public void toLobby()
    {
        SceneManager.LoadScene("LobbyLevel1");
    }
    public void toLobby2()
    {
        SceneManager.LoadScene("LobbyLevel2");
    }

    public void toMainM()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GalleryMenu()
    {
        GalleryM.SetActive(true);
        buttonHandler.SetActive(false);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    public void exitGallery()
    {
        GalleryM.SetActive(false);
        buttonHandler.SetActive(true);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    public void EncyMenu()
    {
        _EncyMenu.SetActive(true);
        buttonHandler.SetActive(false);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    public void exitEncy()
    {
        _EncyMenu.SetActive(false);
        buttonHandler.SetActive(true);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void bgmOn()
    {
        isBGMOn = true;
        BGMobjek.SetActive(true);        
        xBGM.SetActive(false);
        OBGM.SetActive(true);
    }
    public void bgmOff()
    {
        isBGMOn = false;
        BGMobjek.SetActive(false);
        xBGM.SetActive(true);
        OBGM.SetActive(false);
    }

    public void sfxOn()
    {
        isSfxOn = true;
        sfxMobjek.SetActive(true);
        xSfx.SetActive(false);
        OSfx.SetActive(true);
    }
    public void sfxOff()
    {
        isSfxOn = false;
        sfxMobjek.SetActive(false);
        xSfx.SetActive(true);
        OSfx.SetActive(false);
    }


    public GameObject portalM;
    public GameObject winPanel;
    public SoundController soC;
    
    public void toWinPanel()
    {
        soC.bgmWin();
        winPanel.SetActive(true);
        portalM.SetActive(false);
        isBGMOn = false;
        Time.timeScale = 0f;
    }
    
}
