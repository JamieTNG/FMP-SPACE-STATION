using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redherring : MonoBehaviour
{
    public GameObject RoomClean; 
    public GameObject RoomDestroyed;
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RoomClean.SetActive(false);
            RoomDestroyed.SetActive(true);
            audioSource.Play();
        }
    }

}
