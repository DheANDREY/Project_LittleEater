using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource sfx;
    // Start is called before the first frame update
    void Start()
    {
      sfx = GetComponent<AudioSource>();
    }
    public AudioClip dash;
    public void sfxDash()
    {
        sfx.PlayOneShot(dash);
    }
    public AudioClip fus;
    public void sfxEvo()
    {
        sfx.PlayOneShot(fus); 
    }
    public AudioClip makan;
    public void sfxMakan()
    {
        sfx.PlayOneShot(makan);
    }
    public AudioClip bamStun;
    public void sfxbStun()
    {
        sfx.PlayOneShot(bamStun);
    }
    public AudioClip stun;
    public void stuned()
    {
        sfx.PlayOneShot(stun);
    }
    public AudioClip Pheal;
    public void powHeal()
    {
        sfx.PlayOneShot(Pheal);
    }
    public AudioClip Pfood;
    public void powFood()
    {
        sfx.PlayOneShot(Pfood);
    }
    public AudioClip Pgen;
    public void powGen()
    {
        sfx.PlayOneShot(Pgen);
    }
    public AudioClip Pfreeze;
    public void powFreeze()
    {
        sfx.PlayOneShot(Pfreeze);
    }
}
