using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorEvent : MonoBehaviour
{
    public Animator animator;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("DoorClose", true);
        }
    }

}
