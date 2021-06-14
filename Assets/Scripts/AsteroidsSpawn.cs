using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSpawn : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    [SerializeField] private Vector3 spawnValues;
    public float speed = 2.0f;

    private void Start()
    {
        SpawnWaves();
    }

    private void SpawnWaves()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnValues.x, spawnValues.x), 
            spawnValues.y, 
            spawnValues.z
        );

        GameObject tempAsteroid = (GameObject) Instantiate(asteroid, spawnPosition, Quaternion.identity);
        Rigidbody asteroidRigidbody = tempAsteroid.GetComponent<Rigidbody>();
        asteroidRigidbody.velocity = speed * new Vector3(0, -1, 0);
    }
}
