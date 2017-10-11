using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate2 : MonoBehaviour
{
    float zvalue = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        zvalue += 0.1f;
        Vector3 p = new Vector3(0, 0, zvalue);
        transform.position = p;
        if (zvalue > 10)
        {
            zvalue = 0;
        }
    }
}
