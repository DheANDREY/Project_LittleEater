using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transferData1to2 : MonoBehaviour
{
    public static bool objectActive;
    public GameObject lo2;
    public GameObject MaM;

    private void Update()
    {
        if(objectActive == true)
        {
            lo2.SetActive(true);
            MaM.SetActive(false);
            objectActive = false;
        }
    }
}
