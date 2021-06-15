using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Asteroid : MonoBehaviour
{
    [SerializeField] private GameObject splinter;    

    protected float lifeTime = 5.0f;
    

    private void Start()
    {
        Rotate();
        Destroy(gameObject, lifeTime);
    }

    private void OnDestroy()
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

    protected void Rotate()
    {
        gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(3, 3, 3);
    }
}
