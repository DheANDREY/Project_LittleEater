using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class CutScene : MonoBehaviour
{
    public VideoPlayer cutScene;
    private IEnumerator coroutine;
    private GameObject BGM;

    void Start()
    {
        cutScene.Play();
        coroutine = Tutorial();
        StartCoroutine(coroutine);
    }

    IEnumerator Tutorial()
    {
        yield return new WaitForSeconds(70);
        SceneManager.LoadScene("Tutorial1");
    }
}
