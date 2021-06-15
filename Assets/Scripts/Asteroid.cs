using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : SpaceObject
{
    [SerializeField] private GameObject splinter;    
    
    private void Start()
    {
        lifeTime = 6.0f;
        Rotate();
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            int countSplinters = 3;
            for (int i = 0; i < countSplinters; i++)
            {
                System.Random random = new System.Random();
                // TODO: Сделать более рандомный раскол.
                GameObject tempSplinter = Instantiate(splinter, transform.position, Quaternion.identity);
                Rigidbody splinterRigidbody = tempSplinter.GetComponent<Rigidbody>();
                splinterRigidbody.velocity = new Vector3(0, Random.Range(-1, 1), 0);
            }
        }
    }
}
