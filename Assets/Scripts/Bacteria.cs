using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    public Transform[] patrolPoints; //buat 
    public GameObject Character;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;

    float attackCooldown; //fase berhenti dulu
    [SerializeField] private float _attackDuration = 2;

    private bool _isStunned; //cek mau stun apa ga
    private float _stunDuration = 10;
    private float _stunCooldown;

    void Start()
    {
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
        attackCooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (_isStunned)
        {
            if (_stunCooldown > 0)
            {
                _stunCooldown -= Time.deltaTime;
            }
            else
            {
                _isStunned = false;
            }
        }
        else
        {*/
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            float bacteriaToPlayerDistance = Vector3.Distance(Character.transform.position, transform.position);
            if (bacteriaToPlayerDistance > 5)
            {
                // idle, karena masih jauh
            }
            else if (bacteriaToPlayerDistance < 1f)
            {
                if (!Character.GetComponent<Move_CharUtama>())//.boostUsed)
                {
                    rb.velocity = Vector3.zero;

                    if (attackCooldown <= 0)
                    {
                        attackCooldown = _attackDuration;
                        Debug.Log("damage player");
                    }
                }
            }
            else if (bacteriaToPlayerDistance < 5f)
            {
                // chase, kejer player
                Vector3 bacteriaToPlayerDir = transform.position - Character.transform.position;
                /*Debug.Log(bacteriaToPlayerDir.x > 0 ? "hadap kanan" : "hadap kiri");
                if (bacteriaToPlayerDir.x > 0)
                {
                    // flip sprite ke kanan
                    Debug.Log("hadap kanan");
                }
                else
                {
                    // flip sprite ke kiri
                    Debug.Log("hadap kiri");
                }*/

                rb.velocity = bacteriaToPlayerDir.normalized * speed;
            }

            if (attackCooldown > 0)
            {
                attackCooldown -= Time.deltaTime;
            }
        /*}*/

        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     Stun();
        // }

        // transform.Translate(Vector3.up * Time.deltaTime * speed);

        // if (Vector2.Distance(transform.position, Character.transform.position) < 3)
        // {
        //     transform.position = Vector2.MoveTowards(transform.position, Character.transform.position, speed * Time.deltaTime);
        // }else if (Vector3.Distance (transform.position, currentPatrolPoint.position) < .1f)

        // {
        //     if(currentPatrolIndex + 1 < patrolPoints.Length)
        //     {
        //         currentPatrolIndex++;
        //     } else
        //     {
        //         currentPatrolIndex = 0;
        //     }
        //     currentPatrolPoint = patrolPoints[currentPatrolIndex];
        // }
        // Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;

        // float angle = Mathf.Atan2(patrolPointDir.y, patrolPointDir.x) * Mathf.Rad2Deg - 90f;
        // Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        // transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);
    }

    /*public void Stun()
    {
        _isStunned = true;
        _stunCooldown = _stunDuration;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }*/

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.tag == "food5_bacteria")
        {
            if (other.tag == "Player")
            {
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
            }
        }
        //Move_CharUtama move = collider.GetComponent<Move_CharUtama>();
        //if (move != null && move.boostUsed)    // checking player atau bukan, dan lagi dash atau engga
        //{
        //  Stun();
        //}
    }
}
