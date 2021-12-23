using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobby2 : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            /*case "Level":
                SceneManager.LoadScene("CharacterMove");
                break;*/
            case "Settings":
                SceneManager.LoadScene("Settings");
                break;
            case "Back":
                SceneManager.LoadScene("MainMenu");
                break;
            case "Previous":
                SceneManager.LoadScene("LobbyLevel1");
                break;
            case "Next":
                SceneManager.LoadScene("LobbyLevel1");
                break;
            case "Shop":
                SceneManager.LoadScene("Shop");
                break;
            case "Map":
                SceneManager.LoadScene("Map");
                break;
            case "Encyclopedia":
                SceneManager.LoadScene("Encyclopedia");
                break;
                /*case "CreditsButton":
                    SceneManager.LoadScene("Credits");
                    break;
                case "CloseButton":
                    SceneManager.LoadScene("MainMenu");
                    break;
                case "OnButton":
                    OnButton.SetActive(false);
                    OffButton.SetActive(true);
                    break;
                case "OffButton":
                    OffButton.SetActive(false);
                    OnButton.SetActive(true);
                    break;*/
        }
    }
}
