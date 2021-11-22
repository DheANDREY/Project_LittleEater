using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float x;
    public float y;

    void ResetBacteria()
    {
        transform.position = Vector2.zero;
        rigidBody2D.velocity = Vector2.zero;
    }

    void PushBacteria()
    {
        float yRandomForce = Random.Range(-y, y);
        float randomDirection = Random.Range(0, 2);
        if (randomDirection < 1.0f)
        {
            rigidBody2D.AddForce(new Vector2(-x, y));
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(x, y));
        }
    }

    void RestartGame()
    {
        ResetBacteria();
        Invoke("PushBacteria", 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (FoodBar.mCurrentValue <= 300)
        {
            RestartGame();
        }
    }

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
}
