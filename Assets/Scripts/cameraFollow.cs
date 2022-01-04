using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public GameOverScreen GameOverScreen;
    public GameObject GameOverSS;
    public cameraFollow mainCamera;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

        if(FoodBar.mCurrentValue <= 0 && HealthBarScript.health > 0)
        {
            HealthBarScript.health -= Time.deltaTime;
        }

    }

    public void GameOver()
    {
        //if (HealthBarScript.health <= 0f)
        //{
        mainCamera.enabled = false;
        //GameOverScreen.Setup();
        GameOverSS.SetActive(true);
        this.enabled = false;
        //}
    }
}
