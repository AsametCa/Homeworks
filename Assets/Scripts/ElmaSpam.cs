using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElmaSpam : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private Transform[] spawnPoints;

    //[SerializeField] private float spawnDelay;

    //float timer;

    private void Update()
    {
        //timer += Time.deltaTime;
        ////print(timer);

        //if (timer > spawnDelay)
        //{
        //    SpawnApple();

        //    timer = 0;
        //}

        if (Input.GetKeyDown(KeyCode.R))
        {
            SpawnApple();
        }
    }

    private void SpawnApple()
    {
        int index = Random.Range(0, spawnPoints.Length);

        Instantiate(applePrefab, spawnPoints[index].position, spawnPoints[index].rotation);
    }
}