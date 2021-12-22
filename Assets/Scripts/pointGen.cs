using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointGen : MonoBehaviour
{
    public Text poin;
    public Text poin1;
    public Move_CharUtama mcu;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        poin.text = mcu.Score.ToString();
        poin1.text = mcu.Score.ToString();
    }
}
