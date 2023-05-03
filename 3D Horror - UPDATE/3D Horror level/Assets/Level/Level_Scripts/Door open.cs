using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropen : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.SetBool("DoorOpen", false);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("DoorOpen", true);
        }
    }

}
