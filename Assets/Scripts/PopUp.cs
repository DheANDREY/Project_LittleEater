using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject PopUp1;
    public GameObject PopUp2;

    //public void Start()
    //{
      //  PopUp1.SetActive(true);
        //PopUp2.SetActive(false);
    //}

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            PopUp1.SetActive(false);
            PopUp2.SetActive(true);
        }
    }

    /*public void OnMouseDown()
    {
        PopUp1.SetActive(false);
        PopUp2.SetActive(true);
    }*/
}
