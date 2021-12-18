using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    //public Transform[] patrolPoints;
    public GameObject Character;
    private SpriteRenderer _sr;
    public float speed;
   // Transform currentPatrolPoint;
    //int currentPatrolIndex;

    float escapeCooldown;
    [SerializeField] private float _escapeDuration = 2;

    void Start()
    {
        Character = FindObjectOfType<Move_CharUtama>().gameObject;
        _sr = GetComponent<SpriteRenderer>();

        //currentPatrolIndex = 0;
        //currentPatrolPoint = patrolPoints[currentPatrolIndex];
        escapeCooldown = 0;
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float bacteriaToPlayerDistance = Vector3.Distance(Character.transform.position, transform.position);
        if (bacteriaToPlayerDistance > 5)
        {
            rb.velocity = Vector3.zero;
        }
        else if (bacteriaToPlayerDistance < 1f)
        {
            if (!Character.GetComponent<Move_CharUtama>())
            {
                rb.velocity = Vector3.zero;

                if (escapeCooldown <= 0)
                {
                    escapeCooldown = _escapeDuration;
                    Debug.Log("damage player");
                }
            }
        }
        else if (bacteriaToPlayerDistance < 5f)
        {
            Vector3 bacteriaToPlayerDir = transform.position - Character.transform.position;
            rb.velocity = bacteriaToPlayerDir.normalized * speed;
        }

        if (escapeCooldown > 0)
        {
            escapeCooldown -= Time.deltaTime;
        }

        _sr.flipX = rb.velocity.x < 0;
    }

    /*private void OnTriggerEnter2D(Collider2D collider)
    {
        //if (this.tag == "food5_bacteria")
        //{
            //if (other.tag == "Player")
            //{
                if (FoodBar.mCurrentValue <= 300)
                {
                    int value = 8;
                    Destroy(gameObject);
                    FoodBar.mCurrentValue += value;
                    if (FoodBar.mCurrentValue >= 300)
                        FoodBar.mCurrentValue = 300;
                    FoodBar.mCurrentPercent = (float)FoodBar.mCurrentValue / (float)(300);
                }
                else if (FoodBar.mCurrentValue >= 300)
                {
                    FoodBar.mCurrentValue = 300;
                }
            //}
        //}
    }*/
}
