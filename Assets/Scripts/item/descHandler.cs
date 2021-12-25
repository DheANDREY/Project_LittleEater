using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class descHandler : MonoBehaviour
{
    public static descHandler _instance;
    private bool isButtonHover;
    public GameObject[] itemDesc;
    // Start is called before the first frame update
    private void Awake()
    {
            _instance = this;        
    }

    private void Start()
    {
        Cursor.visible = true;
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Input.mousePosition;
    }

    public void ShowDesc(int noDesc)
    {
        itemDesc[noDesc].SetActive(true);
    }
    public void HideDesc(int noDescH)
    {
        itemDesc[noDescH].SetActive(false);
    }
}
