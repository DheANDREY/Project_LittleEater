﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
   
    void Update()
    {
 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthBarScript.health -= 10f;
    }
}
