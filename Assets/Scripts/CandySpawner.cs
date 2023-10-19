using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] candies;

    private void Start()
    {
        for (var i = 0; i < 15; i++)
        {
            Instantiate(candies[Random.Range(0, 5)], new Vector2(Random.Range(-8, 8), 6 + (i * Random.Range(2, 10))), Quaternion.identity);
        }
    }
}
