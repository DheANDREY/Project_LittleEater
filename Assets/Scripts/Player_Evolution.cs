using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Evolution : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public Vector2 moveVel;
    public Rigidbody2D rb;
    public Animator anim;
    public Animator anim2;
    public Animator anim3;

    //public UnityArmatureComponent player;
    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim2 = GetComponent<Animator>();
        anim3 = GetComponent<Animator>();
        //player = GetComponent<UnityArmatureComponent>();
    }
    
    void Update()
    {
        /*Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVel = moveInput.normalized * moveSpeed;

        if (Input.GetKey("s"))
        {
            player.animation.Play(("move"));
        }*/
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //if (FoodBar.mCurrentValue < 100)
        //{
        //    animatorBEV.SetFloat("Horizontal", movement.x);
        //    animatorBEV.SetFloat("Vertical", movement.y);
        //    animatorBEV.SetFloat("Speed", movement.sqrMagnitude);
        //}
        //else if (FoodBar.mCurrentValue >= 100 && FoodBar.mCurrentValue <= 200)
        //{
        //    animatorEV1.SetFloat("Horizontal", movement.x);
        //    animatorEV1.SetFloat("Vertical", movement.y);
        //    animatorEV1.SetFloat("Speed", movement.sqrMagnitude);
        //}
        //else if (FoodBar.mCurrentValue >= 200)
        //{
        //    animatorEV2.SetFloat("Horizontal", movement.x);
        //    animatorEV2.SetFloat("Vertical", movement.y);
        //    animatorEV2.SetFloat("Speed", movement.sqrMagnitude);
        //}
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
