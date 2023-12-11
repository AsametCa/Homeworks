using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElmaSilici : MonoBehaviour
{
   
    [SerializeField] private TMP_Text toplamelma;
    private int toplananelma = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("elma2"))
        {
            toplananelma++;
            toplamelma.SetText("elma sayisi:" + " " + toplananelma);
            
            Destroy(other.gameObject);
        }
    }
   
}
