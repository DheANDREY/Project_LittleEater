using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Move_CharUtama : MonoBehaviour
{
    // [SerializeField] private float _acceleration = 2f;
    [SerializeField] private float _maxSpeed = 5f;

    private Rigidbody2D _rigidBody;
    //private List<Animator> anim;
    public Animator[] anim;
    private int _curentEvoIndex;
    private IEnumerator coroutine;

    private Vector3 _moveDir;

    public SpriteRenderer[] sr;
    private bool isWalk;
    public SoundController soC;

    bool eat;
    public Fillbar fb;
    // public FoodBar foodB;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        fb = GetComponent<Fillbar>();

    }
    //=======
    // gameObject.tag = "Player";

    //>>>>>>> origin/Food_Evolution
    // Update is called once per frame
    void Update()
    {
        if (FoodBar.mCurrentValue >= 100 && FoodBar.mCurrentValue < 200)
        {
            _curentEvoIndex = 1;
            delay();
            
        }
        else if (FoodBar.mCurrentValue >= 200 && FoodBar.mCurrentValue < 300)
        {
            _curentEvoIndex = 2;
            delay();
        }
//  GERAK -------------------------------------------------------------------------------------------
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (move != Vector3.zero)
        {
            _moveDir = move;
            _rigidBody.velocity = _moveDir.normalized * _maxSpeed;
        }
        else
        {
            _rigidBody.velocity = Vector3.zero;
        }
//  -----------------------------------------------------------------------------------------------

        // Char EVO Animation ---------------------------------------------------------------
        if (move.x > 0)
        {
            sr[_curentEvoIndex].flipX = true;
        }
        if (move.x < 0)
        {
            sr[_curentEvoIndex].flipX = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim[_curentEvoIndex].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim[_curentEvoIndex].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim[_curentEvoIndex].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim[_curentEvoIndex].SetBool("isWalk", true);
        }
        else
        {
            anim[_curentEvoIndex].SetBool("isWalk", false);
        }
        //------------------------------------------------------------------------------------------

            dash();
        evoAnim1(); evoAnim2();
    }

    private bool IsDashing = false;
    private float spdDash = 900f;


    public GameObject dashFx;
    bool isEvolving = true;

    private IEnumerator delay()
    {
        if (isEvolving)
        {            
            yield return new WaitForSeconds(3);
            _rigidBody.velocity = Vector3.zero;
        }
        if(!isEvolving)
        {
            Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            _moveDir = move;
            _rigidBody.velocity = _moveDir.normalized * _maxSpeed;
        }
    }

    private void dash()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Fillbar.instance.currentDash >= 50)
        {
            anim[3].SetBool("ngeDash", true);
            Fillbar.instance.kurang(50);            
            if (_rigidBody.velocity.x < 0)
                {
                    GameObject fx = Instantiate(dashFx, new Vector3(_rigidBody.position.x + 2, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
                    fx.transform.SetParent(transform);
                    fx.transform.localScale = new Vector3(1, 1, 0);
                }
                else
                {
                    GameObject fx = Instantiate(dashFx, new Vector3(_rigidBody.position.x + -2, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
                    fx.transform.SetParent(transform);
                    fx.transform.localScale = new Vector3(-1, 1, 0);
                }
                _rigidBody.AddForce(_rigidBody.velocity * spdDash);            
                soC.sfxDash();
                IsDashing = true;                 
        }
        else
        {
            anim[_curentEvoIndex].SetBool("ngeDash", false);
            IsDashing = false;
        }
    }
    public GameObject evo1ke2;
    public GameObject evo2ke3;
    private bool animOn;
    private void evoAnim1()
    {
        if(!animOn && (FoodBar.mCurrentValue >= 100 && FoodBar.mCurrentValue < 200) )
        {
            GameObject fxE = Instantiate(evo1ke2, new Vector3(_rigidBody.position.x, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
            fxE.transform.SetParent(transform);
            fxE.transform.localScale = new Vector3(2, 2, 0);
            animOn = true;
        }
        
    }
    private bool animOn2;
    private void evoAnim2()
    {
        if (!animOn2 && (FoodBar.mCurrentValue >= 200 && FoodBar.mCurrentValue < 300))
        {
            GameObject fxE2 = Instantiate(evo2ke3, new Vector3(_rigidBody.position.x, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
            fxE2.transform.SetParent(transform);
            fxE2.transform.localScale = new Vector3(5/2, 5/2, 0);
            animOn2 = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        OnTriggerEnter2D(collision.collider);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Makanan>() != null)
        {
            // play animasi makanan
            anim[_curentEvoIndex].SetTrigger("isMakan");

            collider.GetComponent<Makanan>().Dimakan();
        }
        else if(collider.GetComponent<Enemy2>() != null && IsDashing)
        {
            // if(collider.GetComponent<Enemy2>()._isStunned)
            // {
                collider.GetComponent<Makanan>().Dimakan();
            // }
            // else
            // {
            //     collider.GetComponent<Enemy2>().Stun();
            // }
        }
    }
}
