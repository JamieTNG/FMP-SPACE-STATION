using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStart : MonoBehaviour
{
    public GameObject gameObject;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(true);
        }
    }
}