using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoor1 : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WallMove();
        }
    }

    // Update is called once per frame
    void WallMove()
    {
        gameObject.transform.position = new Vector3(0.476f, 0.2f, 0f);
    }
}
