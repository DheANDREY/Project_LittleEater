using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private GameObject OnButton;
    private GameObject OffButton;

    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "PlayButton":
                SceneManager.LoadScene("LobbyLevel1");
                break;
            case "SettingsButton":
                SceneManager.LoadScene("Settings");
                break;
            case "ExitButton":
                Application.Quit();
                break;
            case "CreditsButton":
                SceneManager.LoadScene("Credits");
                break;
            case "CloseButton":
                if(FindObjectOfType<MainMenuBGM>().gameObject != null)
                {
                    DestroyImmediate(FindObjectOfType<MainMenuBGM>().gameObject);
                }
                SceneManager.LoadScene("MainMenu");
                break;
        }
    }
}
