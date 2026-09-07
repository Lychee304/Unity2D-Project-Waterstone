using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _coinPrefab;

    [SerializeField] private GameObject _coin;

    [SerializeField] private List<Transform> _coinSpawnLocations = new List<Transform>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            foreach (Transform location in _coinSpawnLocations) // dis ain work in start code, or update, or outside those 2 D:
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(_coin, transform.position, transform.rotation);

                Instantiate(_coinPrefab, location.position, location.rotation);
            }
        }
    }



    // Update is called once per frame
    void Update()
    {

    }

    

}
