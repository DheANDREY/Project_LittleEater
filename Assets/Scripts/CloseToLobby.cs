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
                SceneManager.LoadScene("MainMenu");
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
