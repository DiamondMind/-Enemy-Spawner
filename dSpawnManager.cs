using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dSpawnManager : MonoBehaviour
{
    public GameObject enemPrefab;
    public static int enemyCount;
    public Transform spawnPosition;

    void UpdateSpawnPosition()
    {
        // setting a x and y position for the spawnpoint vector3
        spawnPosition.position = new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), 0);
    }

    void Update()
    { 
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate the enemy prefab at spawnposition transform
            Instantiate(enemPrefab,spawnPosition);
            UpdateSpawnPosition();
        }
    }
}
