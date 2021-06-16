using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : SpaceObject
{
    [SerializeField] private GameObject splinter;

    private void Start()
    {
        lifeTime = 6.0f;
        speed = 2.0f;
        direction = new Vector3(0, -1, 0);

        Rotate();
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            System.Random random = new System.Random();
            int countSplinters = random.Next(1, 4);
            for (int i = 0; i < countSplinters; i++)
            {
               Instantiate(splinter, transform.position, Quaternion.identity);
            }
        }
    }
}
