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
            System.Random random = new System.Random();
            int countSplinters = random.Next(1, 4);
            for (int i = 0; i < countSplinters; i++)
            {                
                GameObject tempSplinter = Instantiate(splinter, transform.position, Quaternion.identity);
                Rigidbody splinterRigidbody = tempSplinter.GetComponent<Rigidbody>();

                // TODO: поправить направление движение осколков.
                float speed = 4;
                int x = Random.Range(-100, 100);
                int y = Random.Range(-100, 100);
                splinterRigidbody.AddForce(x, y, 0);
                splinterRigidbody.velocity = transform.forward * speed;
            }
        }
    }
}
