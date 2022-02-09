using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip explosionSound;
    public static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        explosionSound = Resources.Load<AudioClip>("explosion");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlayExplosionSound()
    {
        audioSrc.PlayOneShot(explosionSound);
    }
}
