using System.Collections;
using System.Collections.Generic;
using Core.Combat;
using UnityEngine;
using BlueGame;

public class ShootLaser : MonoBehaviour
{
    //public GameObject laserPrefab;
    public int ammo;
    public float cooldown;
    
    [SerializeField]
	private KeyCode laser = KeyCode.Mouse0;
	
	float shootTime = 0;
    
	public int laserOnStart = 0; // The number of laser to immediately instantiate when the game starts
	private PoolerManager pooler;

    void Start()
    {
        pooler = PoolerManager.instance;
    }

	
	void Update()
    {
        if (ammo > 0 && Input.GetKey(laser))
        {
            if (Time.time > shootTime + cooldown)
            {
                shootTime = Time.time;

                GameObject myLaser = pooler.Spawn("PLaser", transform.position, Quaternion.identity);  // Pooling System to create or reuse a laser
                myLaser.GetComponent<Projectile>().parent = transform.parent.gameObject;
                ammo--;
            }
        }
    }
}
