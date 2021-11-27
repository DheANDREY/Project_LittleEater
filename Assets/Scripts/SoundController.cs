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
}
