using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraH : MonoBehaviour
{
    public float speed;


    
    //public Transform _Transform;
    public void Start()
    {

    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(speed * -Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, speed * -Time.deltaTime);
        }

    }
}
