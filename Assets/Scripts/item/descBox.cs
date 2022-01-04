using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class descBox : MonoBehaviour
{
    public int r;

    public void show()
    {
        descHandler._instance.ShowDesc(r);
    }

    public void hide()
    {
        descHandler._instance.HideDesc(r);
        //desc.gameObject.SetActive(false);
    }
}
