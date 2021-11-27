
using UnityEngine;

public class Move_CharUtama : MonoBehaviour
{
    [SerializeField] private float _acceleration = 5f;
    [SerializeField] private float _maxSpeed = 10f;

    private Rigidbody2D _rigidBody;
    private Animator anim;

    private SpriteRenderer sr;
    private bool isWalk;
    public SoundController soC;

    bool makan;
    public Fillbar fb;
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        fb = GetComponent<Fillbar>();
        anim = GetComponent<Animator>();
        
        sr = GetComponent<SpriteRenderer>();

     }
    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector3 velocity = _rigidBody.velocity;
        if (move != Vector3.zero)
        {
            velocity += move * _acceleration * Time.deltaTime;
            velocity.x = Mathf.Clamp(velocity.x, -_maxSpeed, _maxSpeed);
            velocity.y = Mathf.Clamp(velocity.y, -_maxSpeed, _maxSpeed);
        }
        else
        {
            velocity.x += (velocity.x > 0 ? -1 : 1) * _acceleration * Time.deltaTime;// Mathf.Clamp(velocity.x, -_maxSpeed, _maxSpeed);
            velocity.y = (velocity.y > 0 ? -1 : 1) * _acceleration * Time.deltaTime;// Mathf.Clamp(velocity.y, -_maxSpeed, _maxSpeed);
        }
        _rigidBody.velocity = velocity;

        if (move.x > 0)
        {
            sr.flipX = true;
        }
        if (move.x < 0)
        {
            sr.flipX = false;
        }
        //else
        //{
        //    sr.flipX = false;
        //}

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isWalk", true);
            Debug.Log(velocity.x);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isWalk", true);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }


        dash();
    }

    private bool boostUsed = false;
    private float spdDash = 100f;

    private void OnTriggerEnter2D(Collider2D food)
    {
        if (food.isTrigger == false)
        {
            makan = true;
            anim.SetTrigger("isMakan");
        }
        Destroy(food.gameObject);
    }
    private void OnTriggerExit2D(Collider2D food)
    {
        anim.ResetTrigger("isMakan");
    }
    private void dash()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Fillbar.instance.currentDash >= 50)
        {
            Fillbar.instance.kurang(50);
            anim.SetBool("isDash", true);
            _rigidBody.AddForce(_rigidBody.velocity * spdDash);
            soC.sfxDash();
            boostUsed = true;            
        }
        else
        {
            anim.SetBool("isDash", false);
        }
    }

}
