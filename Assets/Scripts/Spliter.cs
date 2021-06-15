using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spliter : SpaceObject
{
    private void Start()
    {
        lifeTime = 2.0f;
        Rotate();
        Destroy(gameObject, lifeTime);
    }
}
