using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public GameOverScreen GameOverScreen;
    public cameraFollow mainCamera;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

        if(FoodBar.mCurrentValue <= 0 && HealthBarScript.health > 0)
        {
            HealthBarScript.health -= Time.deltaTime;
        }

        if (HealthBarScript.health <= 0f)// || FoodBar.mCurrentValue <=0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        //if (HealthBarScript.health <= 0f)
        //{
        mainCamera.enabled = false;
        GameOverScreen.Setup();
        this.enabled = false;
        //}
    }
}
