using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globe : MonoBehaviour
{
    private GameObject Sphere;

    // Update is called once per frame
    public void Update()
    {
        transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
}
