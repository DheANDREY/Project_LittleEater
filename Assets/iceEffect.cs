using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceEffect : MonoBehaviour
{
    // Start is called before the first frame update
    private Collider2D radius;

    private void Start()
    {
        radius = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Enemy2 enemy = collider.GetComponent<Enemy2>();
        if(enemy != null && enemy)
        {
            Enemy2.instance.Stun();
        }
    }
}
