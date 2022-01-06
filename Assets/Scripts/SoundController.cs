using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static bool IsSFXOn = true;
    public static bool IsBGMOn = true;

    public AudioSource sfx;
    // Start is called before the first frame update
    void Start()
    {
      sfx = GetComponent<AudioSource>();
    }
    public AudioClip dash;
    public void sfxDash()
    {
        PlaySFX(dash);
    }
    public AudioClip fus;
    public void sfxEvo()
    {
        PlaySFX(fus); 
    }
    public AudioClip makan;
    public void sfxMakan()
    {
        PlaySFX(makan);
    }
    public AudioClip bamStun;
    public void sfxbStun()
    {
        PlaySFX(bamStun);
    }
    public AudioClip stun;
    public void stuned()
    {
        PlaySFX(stun);
    }
    public AudioClip Pheal;
    public void powHeal()
    {
        PlaySFX(Pheal);
    }
    public AudioClip Pfood;
    public void powFood()
    {
        PlaySFX(Pfood);
    }
    public AudioClip Pgen;
    public void powGen()
    {
        PlaySFX(Pgen);
    }
    public AudioClip Pfreeze;
    public void powFreeze()
    {
        PlaySFX(Pfreeze);
    }
    public AudioClip kenaHit;
    public void hitDmg()
    {
        PlaySFX(kenaHit);
    }
    public AudioClip WinSound;
    public void bgmWin()
    {
        PlaySFX(WinSound);
    }
    public void PlaySFX(AudioClip clip)
    {
        if(IsSFXOn)
        {
            sfx.PlayOneShot(clip);
        }
    }
}
