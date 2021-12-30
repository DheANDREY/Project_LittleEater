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
            case "CloseButton":
                SceneManager.LoadScene("LobbyLevel1");
                break;
            case "Back":
                SceneManager.LoadScene("LobbyLevel1");
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
