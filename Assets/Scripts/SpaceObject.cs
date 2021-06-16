using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
abstract public class SpaceObject : MonoBehaviour
{
    protected float lifeTime; 
    protected Rigidbody rbObject;
    protected float speed;
    protected Vector3 direction;

    private void Awake()
    {
        rbObject = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rbObject.velocity = direction.normalized * speed;
    }

    protected void Rotate()
    {
        gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(3, 3, 3);
    }
}
