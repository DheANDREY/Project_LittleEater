using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_CharUtama : MonoBehaviour
{
   // [SerializeField] private float _acceleration = 2f;
    [SerializeField] private float _maxSpeed = 5f;

    private Rigidbody2D _rigidBody;
    //private List<Animator> anim;
    public Animator[] anim;

    private Vector3 _moveDir;

    public SpriteRenderer[] sr;
    private bool isWalk;
    public SoundController soC;

    bool eat;
    public Fillbar fb;
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        fb = GetComponent<Fillbar>();
//<<<<<<< HEAD
       // anim[0] = GetComponent<Animator>();        
       // sr[0] = GetComponent<SpriteRenderer>();
     }
//=======
       // gameObject.tag = "Player";
    
//>>>>>>> origin/Food_Evolution
    // Update is called once per frame
    void Update()
    {
        //Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //Vector3 velocity = _rigidBody.velocity;
        //if (move != Vector3.zero)
        //{
        //    velocity += move * Time.deltaTime;
        //    velocity.x = Mathf.Clamp(velocity.x, -_maxSpeed, _maxSpeed);
        //    velocity.y = Mathf.Clamp(velocity.y, -_maxSpeed, _maxSpeed);
        //    Debug.Log(velocity);
        //}
        //else
        //{
        //    //velocity.x += (velocity.x > 0 ? -1 : 1) * _acceleration * Time.deltaTime;// Mathf.Clamp(velocity.x, -_maxSpeed, _maxSpeed);
        //    //velocity.y = (velocity.y > 0 ? -1 : 1) * _acceleration * Time.deltaTime;// Mathf.Clamp(velocity.y, -_maxSpeed, _maxSpeed);
        //}
        //_rigidBody.velocity = velocity;
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
// Char EVO1 ---------------------------------------------------------------
        if (move.x > 0)
        {
            sr[0].flipX = true;
        }
        if (move.x < 0)
        {
            sr[0].flipX = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim[0].SetBool("isWalk", true);            
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim[0].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim[0].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim[0].SetBool("isWalk", true);
        }
        else
        {
            anim[0].SetBool("isWalk", false);
        }
        //------------------------------------------------------------------------------------------
        // Char EVO2 ---------------------------------------------------------------
        if (move.x > 0)
        {
            sr[1].flipX = true;
        }
        if (move.x < 0)
        {
            sr[1].flipX = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim[1].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim[1].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim[1].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim[1].SetBool("isWalk", true);
        }
        else
        {
            anim[1].SetBool("isWalk", false);
        }
        //------------------------------------------------------------------------------------------
        // Char EVO3 ---------------------------------------------------------------
        if (move.x > 0)
        {
            sr[2].flipX = true;
        }
        if (move.x < 0)
        {
            sr[2].flipX = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim[2].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim[2].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim[2].SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim[2].SetBool("isWalk", true);
        }
        else
        {
            anim[2].SetBool("isWalk", false);
        }
        //------------------------------------------------------------------------------------------
        dash();
    }

    private bool boostUsed = false;
    private float spdDash = 900f;


    public GameObject dashFx;
    private void dash()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Fillbar.instance.currentDash >= 50)
        {
            anim[0].SetBool("ngeDash", true);
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
                boostUsed = true;                 
        }
        else
        {
            anim[0].SetBool("ngeDash", false);
        }

    }
}
