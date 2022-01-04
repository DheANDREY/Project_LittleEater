using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject buttonHandler;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject GalleryM;
    [SerializeField] GameObject _EncyMenu;

    // Update is called once per frame
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
    public void QuitGame()
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
}
