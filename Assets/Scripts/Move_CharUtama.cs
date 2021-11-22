using DragonBones;
using UnityEngine;

public class Move_CharUtama : MonoBehaviour
{
    [SerializeField] private float _acceleration = 5f;
    [SerializeField] private float _maxSpeed = 10f;

    private Rigidbody2D _rigidBody;
    private Animator anim;

    private void Awake()
    {
        UnityArmatureComponent armatureComponent = GetComponent<UnityArmatureComponent>();
        _rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    private UnityArmatureComponent _armature;
    public Fillbar fb;
    private void Start()
    {
        fb = GetComponent<Fillbar>();
        _armature = GetComponent<UnityArmatureComponent>();

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
        dash();

        if (Input.GetKeyDown(KeyCode.A))
        {
            _armature.animation.Play("move", 1);
            return;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _armature.animation.Play("move", 1);
        }
    }
    private bool boostUsed = false;
    private float spdDash = 100f;

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
