using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zeminn : MonoBehaviour
{
    [SerializeField] private TMP_Text dusenelma;
    public int can = 3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("elma2"))
        {
            can -= 1;

            Destroy(other.gameObject);
            print("yere temas etti");
            if (can >= 0)
            {

                dusenelma.SetText("Can:" + " " + can);
            }
            else
            {
                print("can  0 ýn altýna düþtü lütfen yeniden baþlatýn    Can:" + can);

            }

        }
    }
}
