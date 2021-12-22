using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public FoodBar foodB;

    private Inventory inventory;
    public GameObject itemButton;

    public GameObject walkFx;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        fb = GetComponent<Fillbar>();
        inventory = GetComponent<Inventory>();
    }
    //=======
    // gameObject.tag = "Player";

    //>>>>>>> origin/Food_Evolution
    // Update is called once per frame
    void Update()
    {
        if (_curentEvoIndex != 1 && (FoodBar.mCurrentValue >= 100 && FoodBar.mCurrentValue < 200))
        {            
            _curentEvoIndex = 1; 
            evoAnim1(); 
            soC.sfxEvo();
            StartCoroutine(delay());
        }
        else if (_curentEvoIndex != 2 && (FoodBar.mCurrentValue >= 200 && FoodBar.mCurrentValue < 300))
        {
            _curentEvoIndex = 2; 
            evoAnim2(); 
            soC.sfxEvo();
            StartCoroutine(delay());
        }
        else if(_curentEvoIndex != 0 && FoodBar.mCurrentValue < 100)
        {
            _curentEvoIndex = 0;
            evoAnim1();
            soC.sfxEvo();
            StartCoroutine(delay());
        }

        if (!isEvolving)
        {
            //  GERAK -------------------------------------------------------------------------------------------
            Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            if (move != Vector3.zero)
            {
                _moveDir = move;
                _rigidBody.velocity = _moveDir.normalized * _maxSpeed;
                walkFx.SetActive(true);
            }
            else
            {
                walkFx.SetActive(false);
                _rigidBody.velocity = Vector3.zero;
            }
            //  -----------------------------------------------------------------------------------------------

// Char EVO Animation ---------------------------------------------------------------
            if (move.x > 0)
            {
                sr[_curentEvoIndex].flipX = true;
                sr[3].flipX = false; sr[4].flipX = false;

            }
            if (move.x < 0)
            {
                sr[_curentEvoIndex].flipX = false;
                sr[3].flipX = true; sr[4].flipX = true;
            }
            anim[_curentEvoIndex].SetBool("isWalk", move != Vector3.zero);
            //------------------------------------------------------------------------------------------
            
            dash();
        }
         
    }
//JEDA GERAK SAAT ANIMASI ------------------------------------------------------------------------------
    private bool IsDashing = false;
    private float spdDash = 900f;

    public GameObject dashFx;
    public bool isEvolving;

    private IEnumerator delay()
    {
        isEvolving = true;
        _rigidBody.velocity = Vector3.zero;
        // foodB.DecreaseFood(0);
        yield return new WaitForSeconds(2);
        isEvolving = false;
    }
//-----------------------------------------------------------------------------------------------

    //private void walkFX()
    //{
    //    if(!isEvolving)
    //    {
    //        GameObject fx = Instantiate(walkFx, new Vector3(_rigidBody.position.x + 2, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
    //       // fx.transform.SetParent(transform);
    //        fx.transform.localScale = new Vector3(1, 1, 0);
    //    }
    //}
    private void dash()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Fillbar.instance.currentDash >= 50 && (_rigidBody.velocity.x != 0 || _rigidBody.velocity.y != 0))
        {
            //anim[3].SetBool("ngeDash", true);
            anim[_curentEvoIndex].SetTrigger("dash");
            Fillbar.instance.kurang(50);            
            if (_rigidBody.velocity.x < 0)
                {
                    GameObject fx = Instantiate(dashFx, new Vector3(_rigidBody.position.x + 2, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
                    fx.transform.SetParent(transform);
                    fx.transform.localScale = new Vector3(1, 1, 0);
                Destroy(fx, 2);
                }
                else
                {
                    GameObject fx = Instantiate(dashFx, new Vector3(_rigidBody.position.x + -2, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
                    fx.transform.SetParent(transform);
                    fx.transform.localScale = new Vector3(-1, 1, 0);
                Destroy(fx, 2);
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

// VFX ANIMASI TRANSISI EVOLUSI ------------------------------------------------------------------
    public GameObject evo1ke2;
    public GameObject evo2ke3;
    private bool animOn;
    private void evoAnim1()
    {
        if(!animOn)
        {
            GameObject fxE = Instantiate(evo1ke2, new Vector3(_rigidBody.position.x, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
            fxE.transform.SetParent(transform);
            fxE.transform.localScale = new Vector3(2, 2, 0);
            Destroy(fxE, 4);
            //animOn = true;
        }
        
    }
    private bool animOn2;
    private void evoAnim2()
    {
        if (!animOn2)
        {
            GameObject fxE2 = Instantiate(evo2ke3, new Vector3(_rigidBody.position.x, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
            fxE2.transform.SetParent(transform);
            fxE2.transform.localScale = new Vector3(5/2, 5/2, 0);
            Destroy(fxE2, 4);
            //animOn2 = true;
        }
    }
//-------------------------------------------------------------------------------------------

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnTriggerEnter2D(collision.collider);
        
    }
    public GameObject hitVfx;
    public dropItem di;
    public Food[] fd;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Enemy2>() != null)
        {
            
            if (collider.GetComponent<Enemy2>().IsStunned)
            {             
                anim[_curentEvoIndex].SetTrigger("isMakan");
                collider.GetComponent<Food>().Dimakan(); soC.sfxMakan(); 
                IncrementScore(Food.instance._valueMakanan);
                di.itemDrop();
                Fillbar.instance.kurang(-50);
            }
            else 
            {
                if(IsDashing)
                {
                    GameObject fxE = Instantiate(hitVfx, new Vector3(_rigidBody.position.x + 1, _rigidBody.position.y, 0), Quaternion.identity) as GameObject;
                    fxE.transform.SetParent(transform);
                    fxE.transform.localScale = new Vector3(1, 1, 0);
                    soC.sfxbStun();
                    collider.GetComponent<Enemy2>().Stun();
                    Destroy(hitVfx, 3);
                }
            }
        }
        else if(collider.GetComponent<Food>() != null)
        {
            // play animasi makanan
            anim[_curentEvoIndex].SetTrigger("isMakan");
            collider.GetComponent<Food>().Dimakan(); soC.sfxMakan(); 
            IncrementScore(Food.instance._valueMakanan);
            Fillbar.instance.kurang(-50);
            
        }     
    }
    private int score;
    public void IncrementScore(int nilai)
    {
        score += nilai;
    }
    public int Score
    {
        get { return score; }
    }

}
