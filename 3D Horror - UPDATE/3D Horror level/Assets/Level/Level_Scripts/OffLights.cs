using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffLights : MonoBehaviour
{
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          gameObject.SetActive(false);
        }
    }
}
