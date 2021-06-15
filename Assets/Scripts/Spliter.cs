using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spliter : Asteroid
{
    private void Start()
    {
        lifeTime = 2.0f;
        Rotate();
        Destroy(gameObject, lifeTime);
    }
}
