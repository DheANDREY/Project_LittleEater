using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{
    [Header("Position")]
    public Transform player;
    public float horizontalOffset;
    //public GameOverScreen GameOverScreen;

    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.position.x + horizontalOffset;
        newPosition.y = player.position.y + horizontalOffset;
        transform.position = newPosition;
    }

    /*public void GameOver()
    {
        if(HealthBarScript.health <= 0)
        {
            GameOverScreen.Setup();
        }
    }*/
}
