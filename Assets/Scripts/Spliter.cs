using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spliter : SpaceObject
{
    private Rigidbody rigidbody;
    private float speed = 6;
    private Vector3 direction;

    private void Start()
    {
        lifeTime = 4.0f;
        Rotate();
        rigidbody = GetComponent<Rigidbody>();

        direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);

        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        rigidbody.velocity = direction.normalized * speed;
    }
}
