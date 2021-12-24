using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButton : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Retry":
                SceneManager.LoadScene("CharacterMove");
                break;
            case "Lobby":
                SceneManager.LoadScene("LobbyLevel1");
                break;
        }
    }
}
