using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy3 : MonoBehaviour
{
    // public Transform[] patrolPoints;
    public GameObject Character;
    private Rigidbody2D rb;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;
    float attackCooldown;
    public Vector3 homePos;

    [SerializeField] private float _attackDuration = 2;

    public bool IsStunned;
    bool sekali;

    private float _stunDuration = 3;

    private float _stunCooldown;

    private Transform player;

    private Animator myAnim;

    public Animator StunE;
    public GameObject stunFx;
    public SpriteRenderer sr;

    private float timeBtwShoot;
    public float startTimeBtwShoot;
    public GameObject bullet;
    private AudioSource auS;

    //public static Enemy2 instance;

    private void Awake()
    {
        if (Character == null)
        {
            Character = FindObjectOfType<Move_CharUtama>().gameObject;
        }
        //instance = this;
    }

    void Start()
    {
        homePos = transform.position;

        attackCooldown = 0;
        myAnim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        timeBtwShoot = startTimeBtwShoot;
        auS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsStunned)
        {
            if (_stunCooldown > 0)
            {
                if (!sekali)
                {
                    GameObject fx = Instantiate(stunFx, new Vector3(rb.position.x, rb.position.y + 1, 0), Quaternion.identity) as GameObject;
                    Debug.Log(stunFx);
                    fx.transform.SetParent(transform);
                    fx.transform.localScale = new Vector3(1, 1, 0);
                    sekali = true;
                }
                _stunCooldown -= Time.deltaTime;


            }
            else
            {
                IsStunned = false;
            }
        }
        else
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            float enemyToPlayerDistance = Vector3.Distance(Character.transform.position, transform.position);
            if (enemyToPlayerDistance > 6f)
            {
                Vector3 enemyToPlayerDir = Character.transform.position - transform.position;
                {
                    GoHome();
                }
            }
            else if (enemyToPlayerDistance < 1f)
            {
                if (Character.GetComponent<Move_CharUtama>() != null)
                {
                    rb.velocity = Vector3.zero;

                    if (attackCooldown <= 0)
                    {
                        attackCooldown = _attackDuration;
                        HealthBarScript.instance.hpBerkurang(5);

                        Debug.Log("attack");
                    }
                }
            }
            else if (enemyToPlayerDistance < 6f)
            {
                // chase, kejer player
                Vector3 enemyToPlayerDir = Character.transform.position - transform.position;
                //myAnim.SetBool("isMoving", true);
                //myAnim.SetFloat("moveX", (target.position.x - transform.position.x));
                //myAnim.SetFloat("moveY", (target.position.y - transform.position.y));
                rb.velocity = enemyToPlayerDir.normalized * speed;
            }


            if (attackCooldown > 0)
            {
                attackCooldown -= Time.deltaTime;
            }
        }

        if (rb.velocity.x > 0)
        {
            sr.flipX = false;
        }
        if (rb.velocity.x < 0)
        {
            sr.flipX = true;
        }

        if (timeBtwShoot <= 0)
        {
            GameObject h4 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;

            Destroy(h4, 3);
            // Destroy(bullet, 7);
            timeBtwShoot = startTimeBtwShoot;
        }
        else
        {
            timeBtwShoot -= Time.deltaTime;
        }
    }

    public AudioClip stun;
    public void Stun()
    {
        Debug.Log("stun");
        IsStunned = true; 
        _stunCooldown = _stunDuration; 
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        auS.PlayOneShot(stun);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Move_CharUtama move = collider.GetComponent<Move_CharUtama>();
        if (move != null && move)    // checking player atau bukan, dan lagi dash atau engga
        {
            Stun();
        }
    }

    public void GoHome()
    {
        //myAnim.SetFloat("moveX", (target.position.x - transform.position.x));
        //myAnim.SetFloat("moveY", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, homePos, speed * Time.deltaTime);
    }
}