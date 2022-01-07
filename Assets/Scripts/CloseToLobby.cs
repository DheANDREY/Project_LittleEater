using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseToLobby : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Back":
                _mainMenu.SetActive(false);
                Settings.SetActive(false);
                Credits.SetActive(false);
                Lobby1.SetActive(true);
                Lobby2.SetActive(false);
                Galleries.SetActive(false);
                Encyclopedia.SetActive(false);
                Shop.SetActive(false);
                break;
            case "CloseToPlay":
                SceneManager.LoadScene("CharacterMove");
                break;
            case "BackToPlay":
                SceneManager.LoadScene("CharacterMove");
                break;
        }
    }
}
