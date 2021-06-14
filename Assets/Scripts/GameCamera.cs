using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    private static Vector2 size;
    public static Vector2 Size
    { 
        get
        {
            return size;
        }
    }


    private void Start()
    {
        var camera = Camera.main;
        size = new Vector2(camera.orthographicSize * camera.aspect, 
            camera.orthographicSize * camera.aspect);
    }
}
