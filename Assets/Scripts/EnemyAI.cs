using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject Character;
    public float speed;


    void Update()
    {
        if(Vector2.Distance(transform.position, Character.transform.position) < 3)
        transform.position = Vector2.MoveTowards(transform.position, Character.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthBarScript.health -= 10f;
    }
}
