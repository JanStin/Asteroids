using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float speed = 5.0f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {        
        if (Input.GetKey(KeyCode.D) 
            && transform.position.x < GameCamera.Size.x - transform.localScale.x / 2)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) 
            && transform.position.x > -GameCamera.Size.x + transform.localScale.x / 2)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
