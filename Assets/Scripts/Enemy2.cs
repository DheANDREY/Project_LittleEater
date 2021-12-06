using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy2 : MonoBehaviour
{
    public Transform[] patrolPoints;
    public GameObject Character;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;
    float attackCooldown;
    public Transform homePos;

    [SerializeField] private float _attackDuration = 2;

    private bool _isStunned;

    private float _stunDuration = 3;

    private float _stunCooldown;

    private Transform target;

    private Animator myAnim;

    void Start()
    {
        //currentPatrolIndex = 0;
        //currentPatrolPoint = patrolPoints[currentPatrolIndex];
        attackCooldown = 0;
        myAnim = GetComponent<Animator>();

        target = FindObjectOfType<Move_CharUtama>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isStunned)
        {
            if(_stunCooldown > 0)
            {
                _stunCooldown -= Time.deltaTime;
                myAnim.SetBool("StunerAI", true);           
            }
            else
            {
                _isStunned = false;
            }
        }
        else
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            float enemyToPlayerDistance = Vector3.Distance(Character.transform.position, transform.position);
            if(enemyToPlayerDistance > 6f)
            {
                Vector3 enemyToPlayerDir = Character.transform.position - transform.position;
                {
                    GoHome();
                }
            }
            else if(enemyToPlayerDistance < 1f)
            {
                if (!Character.GetComponent<Move_CharUtama>())
                {
                    rb.velocity = Vector3.zero;

                    if(attackCooldown <= 0)
                    {
                        attackCooldown = _attackDuration;
                        HealthBarScript.health -= 10f;
                    }
                }
            }

            else if(enemyToPlayerDistance < 5f)
            {
                // chase, kejer player
                Vector3 enemyToPlayerDir = Character.transform.position - transform.position;
                myAnim.SetBool("isMoving", true);
                myAnim.SetFloat("moveX", (target.position.x - transform.position.x));
                myAnim.SetFloat("moveY", (target.position.y - transform.position.y));
                //Debug.Log(enemyToPlayerDir.x > 0 ? "hadap kanan" : "hadap kiri");
                //if(enemyToPlayerDir.x > 0)
                //{
                // flip sprite ke kanan
                //    myAnim.SetBool("EidleRight", true);
                //    Debug.Log("hadap kanan");
                //}
                //else
                //{
                // flip sprite ke kiri
                //myAnim.SetBool("EidleLeft", true);
                //Debug.Log("hadap kiri");
                //}            
                rb.velocity = enemyToPlayerDir.normalized * speed;
            }


            if (attackCooldown > 0)
            {
                attackCooldown -= Time.deltaTime;
            }
        }
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

    public void Stun()
    {
        Debug.Log("stun");
        _isStunned = true;
        _stunCooldown = _stunDuration;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Move_CharUtama move = collider.GetComponent<Move_CharUtama>();
        if(move != null && move)    // checking player atau bukan, dan lagi dash atau engga
        {
            Stun();
        }
    }

    public void GoHome()
    {
        myAnim.SetFloat("moveX", (target.position.x - transform.position.x));
        myAnim.SetFloat("moveY", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime);
    }
}