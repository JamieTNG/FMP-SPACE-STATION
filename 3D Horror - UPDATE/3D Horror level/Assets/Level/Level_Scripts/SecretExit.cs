using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretExit : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject DoorDisable;
    public GameObject DoorEnable;
    public GameObject TriggerEnable;

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
        gameObject.transform.position = new Vector3(76.03f, 4f, 36.384f);
        DoorDisable.SetActive(false);
        DoorEnable.SetActive(true);
        TriggerEnable.SetActive(true);
    }
}
