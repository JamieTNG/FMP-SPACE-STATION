 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.tag == "Player" && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
