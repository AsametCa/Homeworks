using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sepetsilici : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("sepet"))
        {
            
            Destroy(other.gameObject);
        }
    }
}
