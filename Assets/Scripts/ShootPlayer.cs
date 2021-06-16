using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject laser;
    [SerializeField] private Transform firePoint;

    private float cooldownLaser = 10.0f;
    private float rechargeTimeOneShoot;
    private float rechargeTimeTwoShoot;

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
        if (Input.GetMouseButtonDown(1) && !CooldownLaser())
        {
            Vector3 laserPosition = new Vector3(firePoint.position.x, firePoint.position.y + 6, 0);
            Instantiate(laser, laserPosition, firePoint.rotation);
        }
        rechargeTimeOneShoot += Time.deltaTime;
        rechargeTimeTwoShoot += Time.deltaTime;
    }

    private bool CooldownLaser()
    {
        if (rechargeTimeOneShoot > cooldownLaser)
        {
            rechargeTimeOneShoot = 0;
            return false;
        }
        else if (rechargeTimeTwoShoot > cooldownLaser)
        {
            rechargeTimeTwoShoot = 0;
            return false;
        }

        return true;
    }
}
