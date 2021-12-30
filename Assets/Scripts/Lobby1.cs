﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobby1 : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Level":
                //DestroyImmediate(FindObjectOfType<MainMenuBGM>().gameObject);
                SceneManager.LoadScene("CutScene");
                break;
            case "Settings":
                SceneManager.LoadScene("Settings");
                break;
            case "Back":
                SceneManager.LoadScene("MainMenu");
                break;
            case "Next":
                SceneManager.LoadScene("LobbyLevel2");
                break;
            case "Shop":
                SceneManager.LoadScene("Shop");
                break;
            case "Galleries":
                SceneManager.LoadScene("Galleries");
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
