
using UnityEngine;

public class Move_CharUtama : MonoBehaviour
{
    [SerializeField] private float _acceleration = 5f;
    [SerializeField] private float _maxSpeed = 10f;

    private Rigidbody2D _rigidBody;
    private Animator anim;
    private SpriteRenderer sr;

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
        

        if (Input.GetKeyDown(KeyCode.A) ||  Input.GetKeyDown(KeyCode.LeftArrow))
        {
        
            anim.SetFloat("Horizon", Input.GetAxis("Horizontal"));
            Debug.Log(Input.GetAxis("Horizontal"));
           
        }


        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {           
            anim.SetFloat("Horizon", Input.GetAxis("Horizontal"));           
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
            anim.SetBool("makan", true);
        }
        Destroy(food.gameObject);
    }
    private void OnTriggerExit2D(Collider2D food)
    {
        anim.SetBool("makan", true);
    }
    private void dash()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Fillbar.instance.currentDash >= 50)
        {

            Fillbar.instance.kurang(50);
            _rigidBody.AddForce(_rigidBody.velocity * spdDash);
            boostUsed = true;
        }
    }

}
