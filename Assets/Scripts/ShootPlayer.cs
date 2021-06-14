using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;

    private void Update()
    {
        Shoot();   
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject tempBullet = 
                (GameObject)Instantiate(bullet, firePoint.position, firePoint.rotation);

            Rigidbody bulletRigidbody = tempBullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = 12.0f * firePoint.transform.TransformVector(new Vector3(0, 1, 0));
        }
    }
}
