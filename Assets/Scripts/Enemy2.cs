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

    public GameObject StunE;

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
                rb.velocity = enemyToPlayerDir.normalized * speed;
            }


            if (attackCooldown > 0)
            {
                attackCooldown -= Time.deltaTime;
            }
        }
    }

    public void Stun()
    {
        Debug.Log("stun");
        _isStunned = true;
        _stunCooldown = _stunDuration ;        
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Move_CharUtama move = collider.GetComponent<Move_CharUtama>();
        if (move != null && move)    // checking player atau bukan, dan lagi dash atau engga
        {
            Stun();
        }

        else
        {
            HealthBarScript.health -= 10f;
        }
    }

    public void GoHome()
    {
        myAnim.SetFloat("moveX", (target.position.x - transform.position.x));
        myAnim.SetFloat("moveY", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime);
    }
}