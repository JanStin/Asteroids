using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        

        Vector3 movement = new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
        rigidbody.MovePosition(rigidbody.position + movement);
    }
}
