using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public GameObject _mainMenu, Settings, Credits, Lobby1, Lobby2, Galleries, Encyclopedia, Shop, BGM, OnBgm, OffBgm;

    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "PlayButton":
                _mainMenu.SetActive(false);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(true);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "SettingsButton":
                _mainMenu.SetActive(false);
                Settings.SetActive(true);
                Credits.SetActive(false);
                Lobby1.SetActive(false);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "ExitButton":
                Application.Quit();
                break;
            case "CreditsButton":
                _mainMenu.SetActive(false);
                Settings.SetActive(false);
                Credits.SetActive(true);
                Lobby1.SetActive(false);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "Close":
                _mainMenu.SetActive(true);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(false);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "Level":
                Destroy(BGM);
                SceneManager.LoadScene("CutScene");
                break;
            case "Settings":
                _mainMenu.SetActive(false);
                Settings.SetActive(true);
                Credits.SetActive(false);
                Lobby1.SetActive(false);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "Back":
                _mainMenu.SetActive(true);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(false);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "Next":
                _mainMenu.SetActive(false);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(false);
                Lobby2.SetActive(true);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "Previous":
                _mainMenu.SetActive(false);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(true);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "BackToLobby":
                _mainMenu.SetActive(false);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(true);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "Shop":
                SceneManager.LoadScene("Shop");
                break;
            case "Galleries":
                _mainMenu.SetActive(false);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(false);
                Lobby2.SetActive(false);
                Galleries.SetActive(true);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "Encyclopedia":
                _mainMenu.SetActive(false);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(false);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(true);
                Shop.SetActive(false);
                break;
            case "OnBgm":
                OnBgm.SetActive(false);
                OffBgm.SetActive(true);
                BGM.SetActive(true);
                break;
            case "OffBgm":
                OffBgm.SetActive(false);
                OnBgm.SetActive(true);
                BGM.SetActive(false);
                break;
        }
    }
   
}
