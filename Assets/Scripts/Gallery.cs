using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gallery : MonoBehaviour
{
    public GameObject Chapter1, Chapter2, Chapter3, Chapter4;
    public GameObject PopUp1, PopUp2, PopUp3, PopUp4;

    public void OnMouseDown()
    {
        switch (this.gameObject.name)
        {
            case "TextChapter1":
                Chapter1.SetActive(true);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "TextChapter2":
                Chapter1.SetActive(false);
                Chapter2.SetActive(true);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "TextChapter3":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(true);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "TextChapter4":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(true);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "PopUpIcon1":
                Chapter1.SetActive(true);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(true);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "PopUpIcon2":
                Chapter1.SetActive(false);
                Chapter2.SetActive(true);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(true);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "PopUpIcon3":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(true);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(true);
                PopUp4.SetActive(false);
                break;
            case "PopUpIcon4":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(true);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(true);
                break;
            case "Next4":
                Chapter1.SetActive(true);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(true);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "Next1":
                Chapter1.SetActive(false);
                Chapter2.SetActive(true);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(true);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "Next2":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(true);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(true);
                PopUp4.SetActive(false);
                break;
            case "Next3":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(true);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(true);
                break;
            case "Previous2":
                Chapter1.SetActive(true);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(true);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "Previous3":
                Chapter1.SetActive(false);
                Chapter2.SetActive(true);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(true);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "Previous4":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(true);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(true);
                PopUp4.SetActive(false);
                break;
            case "Previous1":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(true);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(true);
                break;
            case "Close1":
                Chapter1.SetActive(true);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "Close2":
                Chapter1.SetActive(false);
                Chapter2.SetActive(true);
                Chapter3.SetActive(false);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "Close3":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(true);
                Chapter4.SetActive(false);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
            case "Close4":
                Chapter1.SetActive(false);
                Chapter2.SetActive(false);
                Chapter3.SetActive(false);
                Chapter4.SetActive(true);
                PopUp1.SetActive(false);
                PopUp2.SetActive(false);
                PopUp3.SetActive(false);
                PopUp4.SetActive(false);
                break;
        }

    }
}