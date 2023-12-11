using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SepetSpam : MonoBehaviour
{
    [SerializeField] private GameObject SepetPrefab;
    [SerializeField] private Transform[] SepetSpamNoktasý;


    private void OnTriggerEnter(Collider other)
    {




        if (other.gameObject.CompareTag("elma2"))
        {
            SpawnSepet();
        }
    }

    private void SpawnSepet()
    {
        int index = Random.Range(0, SepetSpamNoktasý.Length);

        Instantiate(SepetPrefab, SepetSpamNoktasý[index].position, SepetSpamNoktasý[index].rotation);
    }
}
