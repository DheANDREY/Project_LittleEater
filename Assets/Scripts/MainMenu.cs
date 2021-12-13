using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "PlayButton":
                SceneManager.LoadScene("CharacterMove");
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
                SceneManager.LoadScene("MainMenu");
                break;
        }
    }
}
