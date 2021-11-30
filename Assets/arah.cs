using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arah : MonoBehaviour
{
    private SpriteRenderer spriteR;
    private Rigidbody2D rigFx;
    public Move_CharUtama mcu;
    // Start is called before the first frame update
    void Start()
    {
        rigFx = GetComponent<Rigidbody2D>();
        spriteR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigFx.position.x > 0)
        {
            spriteR.flipX = false;
        }
        if (rigFx.position.x < 0)
        {
            spriteR.flipX = true;
        }
    }
}
