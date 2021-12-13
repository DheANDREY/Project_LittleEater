using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_kurang : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fillbar.instance.kurang(50);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            HealthBarScript.health += 10f;
            Debug.Log(HealthBarScript.health);
        }
    }
}
