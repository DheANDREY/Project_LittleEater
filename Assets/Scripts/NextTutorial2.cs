using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTutorial2 : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Next":
                SceneManager.LoadScene(/*"Tutorial3*/"CharacterMove");
                break;
        }
    }
}
