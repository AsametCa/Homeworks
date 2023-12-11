using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomspam : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;

    void Start()
    {
        x = Random.Range(-5, 5);
        y = 0;
        z = Random.Range(-5, 5);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
}
