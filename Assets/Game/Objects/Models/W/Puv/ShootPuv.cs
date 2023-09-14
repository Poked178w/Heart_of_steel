using sr;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShootPuv : MonoBehaviour
{
    public GameObject weapon;
    public GameObject projectile;
    private float rate_of_fire = 10f;
    private float time_of_fire = 10f;
    private float power_fire = 150f; // Не путать с уроном от выстрела

    void Start()
    {

    }


    void Update()
    {
        time_of_fire += Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if (time_of_fire >= rate_of_fire)
            {
                time_of_fire = 0;
                Fire();
            }
        }
    }

    private void Fire()
    {
        GameObject projectile_fire = Instantiate(projectile) as GameObject;
        projectile_fire.transform.position = weapon.transform.position;
        projectile_fire.transform.rotation = weapon.transform.rotation;
        projectile_fire.transform.Translate(0, 0, 3);
        projectile_fire.GetComponent<Rigidbody>().AddRelativeForce(projectile_fire.transform.forward * power_fire, ForceMode.VelocityChange);
    }
}
