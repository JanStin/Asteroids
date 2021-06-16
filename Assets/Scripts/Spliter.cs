using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spliter : SpaceObject
{
    private void Start()
    {
        lifeTime = 4.0f;
        speed *= 2;
        direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
        Rotate();
        Destroy(gameObject, lifeTime);
    }
}
