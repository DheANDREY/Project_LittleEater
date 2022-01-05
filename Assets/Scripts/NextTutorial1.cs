using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTutorial1 : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Next":
                SceneManager.LoadScene("Tutorial2");
                break;
            case "Skip":
                SceneManager.LoadScene("CharacterMove");
                break;
        }
    }
}
