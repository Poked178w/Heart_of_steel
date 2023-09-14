using sr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class ShootAnger : MonoBehaviour
{
    public GameObject weapon;
    public GameObject projectile;
    //public Text ammoText;
    private float rate_of_fire = 0.15f;
    private float time_of_fire = 0.15f;
    private float power_fire = 100f; // Не путать с уроном от выстрела
    private float recharge = 8.0f;
    private int ammo = 60;

    private float rndX;

    private Animator spin;

    private float OnSpin;

    void Start()
    {
        spin = GetComponent<Animator>();
        //ammoText = GetComponent<Text>();    
    }


    void FixedUpdate()
    {
        time_of_fire += Time.deltaTime;
        UpdateAmmoText();

        if (ammo <= 0) { recharge -= Time.deltaTime; Debug.Log("Recharge: " + recharge); }
        if (recharge <= 0) { recharge = 8.0f; ammo = 60; }

        if (Input.GetMouseButton(0))
            {
                if (ammo >= 1)
                {
                    if (time_of_fire >= rate_of_fire)
                    {
                        time_of_fire = 0;
                        Fire();
                        ammo--;
                        Debug.Log("Ammo: " + ammo);
                    }
                    spin.SetFloat("OnSpin", Mathf.Abs(OnSpin = 1));
                }
            }
            else
            {
                spin.SetFloat("OnSpin", Mathf.Abs(OnSpin = 0));
            }
    }

    private void UpdateAmmoText()
    {
        // Обновляет текстовый компонент с текущим количеством боеприпасов
        //ammoText.text = ammo.ToString();
    }

    private void Fire()
    {
        GameObject projectile_fire = Instantiate(projectile) as GameObject;
        projectile_fire.transform.position = weapon.transform.position;
        projectile_fire.transform.rotation = weapon.transform.rotation;
        rndX = UnityEngine.Random.Range(-3f, 3f);
        projectile_fire.transform.Translate(0, 0, 3);
        projectile_fire.transform.Rotate(rndX, 0, 0);
        projectile_fire.GetComponent<Rigidbody>().AddRelativeForce(projectile_fire.transform.forward * power_fire, ForceMode.VelocityChange);

    }
}
