using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlay : MonoBehaviour
{
    // Start is called before the first frame update
  
    
        public AudioSource audioSource;
        public AudioClip clip;
        public float volume = 0.5f;

        void Start()
        {
            audioSource.PlayOneShot(clip, volume);
        }
    
}
