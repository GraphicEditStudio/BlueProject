using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public GameObject laserPrefab;
    KeyCode laser = KeyCode.Mouse0;
    public int ammo;
    public float cooldown;
    float shootTime = 0;
    void Update()
    {
        if (ammo > 0 && Input.GetKeyDown(laser))
        {
            if (Time.time > shootTime + cooldown)
            {
                shootTime = Time.time;
                Instantiate(laserPrefab, transform);
                ammo--;
            }
        }
    }
}
