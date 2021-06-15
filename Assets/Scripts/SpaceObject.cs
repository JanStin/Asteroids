using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
abstract public class SpaceObject : MonoBehaviour
{
    protected float lifeTime;

    protected void Rotate()
    {
        gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(3, 3, 3);
    }
}
