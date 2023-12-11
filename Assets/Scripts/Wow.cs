using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wow : MonoBehaviour
{
    [SerializeField] private TMP_Text appleCountText;
    private int appleCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("elma2"))
        {
            print("Elma girdi");
            appleCount++;
            appleCountText.SetText("Elma Sayisi : " + appleCount);
            Destroy(other.gameObject);
            print("Elma Sayisi : " + appleCount);
        }
    }
}
