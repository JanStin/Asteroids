using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    private static Vector2 size;
    private Camera camera;
    public static Vector2 Size
    { 
        get
        {
            return size;
        }
    }


    private void Start()
    {
        camera = Camera.main;
        size = new Vector2(camera.orthographicSize * camera.aspect, 
            camera.orthographicSize * camera.aspect);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (camera.orthographic)
            {
                camera.orthographic = false;
                gameObject.transform.position = new Vector3(0, -11, -3);
                gameObject.transform.Rotate(-75, 0, 0);
            }
            else
            {
                camera.orthographic = true;
                gameObject.transform.position = new Vector3(0, 0, -10);
                gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
            }
        }
    }
}
