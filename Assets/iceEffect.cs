using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceEffect : MonoBehaviour
{
    // Start is called before the first frame update
    private Collider2D radius;
    public GameObject enemyToFreeze1;
    public GameObject enemyToFreeze2;

    private void Start()
    {
        radius = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (enemyToFreeze2 != null)
        {
            collider.GetComponent<Enemy2>().Stun();
        }
    }
}
