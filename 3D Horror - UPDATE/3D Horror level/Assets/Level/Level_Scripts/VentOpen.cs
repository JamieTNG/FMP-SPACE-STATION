using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentOpen : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject DoorDisable;
    public GameObject DoorEnable;
    public AudioSource audioSource;
    public AudioSource audioMusic;
    public Vector3 moveDirection;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.tag == "Player" && !audioSource.isPlaying)
            {
                audioSource.Play();
                audioMusic.Play();
            }
            Vent();
        }
    }

    // Update is called once per frame
    void Vent()
    {
        gameObject.transform.position = new Vector3(21f, 2.5f, 47.84f);
        DoorDisable.SetActive(false);
        DoorEnable.SetActive(true);
    }

    
}
