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
        // if (enemyToFreeze2 != null)
        // {
            collider.GetComponent<Enemy2>()?.Stun();
        // }
    }

    private void CheckAreaStun()
    {
        Collider2D[] results = new Collider2D[100];
        ContactFilter2D filter = new ContactFilter2D();
        filter.layerMask = LayerMask.NameToLayer("Enemy");
        if(Physics2D.OverlapCircle(transform.position, 5, filter, results) > 0)
        {
            foreach(Collider2D result in results)
            {
                if(result == null) { continue; }

                if(result.GetComponent<Enemy1>() != null)
                {
                    result.GetComponent<Enemy1>().Stun();
                }
                else if(result.GetComponent<Enemy2>() != null)
                {
                    result.GetComponent<Enemy2>().Stun();
                }
                else if(result.GetComponent<Enemy3>() != null)
                {
                    result.GetComponent<Enemy3>().Stun();
                }
            }
        }
    }
}
