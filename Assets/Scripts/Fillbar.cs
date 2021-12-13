using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Fillbar : MonoBehaviour
{
	public Slider slider1;
    public int maxDash = 100;
    public int currentDash;

    private WaitForSeconds regenTime = new WaitForSeconds(0.1f);
    private Coroutine regenerate;

    public static Fillbar instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        currentDash = maxDash;  
        slider1.maxValue = maxDash;
        slider1.value = maxDash;
    }
    private void Update()
    {
        if(currentDash > 100)
        {
            currentDash = 100;
            Debug.Log(currentDash);
        }
    }

    // BAR DASH BERKURANG ------------------------------------------------------------------
    public void kurang(int nilai)
    {
        if(currentDash - nilai >= 0)
        {
            currentDash -= nilai;
            Debug.Log(currentDash);
            slider1.value = currentDash;      
            if(regenerate != null)
            {
                StopCoroutine(regenerate);
            }
            regenerate = StartCoroutine(regenDash());
        }
        else
        {
            Debug.Log("Tidak cukup");
        }
    }
//-----------------------------------------------------------------------------------------

// REGEN BAR DASH -------------------------------------------------------------------------
    private IEnumerator regenDash()
    {
        yield return new WaitForSeconds(5);
        while(currentDash < maxDash)
        {
            currentDash += maxDash/50 ;
            slider1.value = currentDash;
            yield return regenTime;
        }

    }
//-------------------------------------------------------------------------------------------
}
