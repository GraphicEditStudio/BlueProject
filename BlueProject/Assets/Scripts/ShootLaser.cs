using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlueGame;

public class ShootLaser : MonoBehaviour
{
    //public GameObject laserPrefab;
    public int ammo;
    public float cooldown;
    
	KeyCode laser = KeyCode.Mouse0;
	
	float shootTime = 0;
    
	public int laserOnStart = 0; // The number of laser to immediately instantiate when the game starts
	private MainPool laserPooler;

    void Start()
    {
        
        laserPooler = GeneralPoolerManager.GetObjectPooler(0); // Pooler Manager 
		
        if (laserOnStart > 0) laserPooler.InitializePool(laserOnStart); //how many bullets
    }

	
	void Update()
    {
        if (ammo > 0 && Input.GetKeyDown(laser))
        {
            if (Time.time > shootTime + cooldown)
            {
                shootTime = Time.time;
               
			   //Instantiate(laserPrefab, transform);
					 
				GameObject myLaser = laserPooler.GetObject(); // Pooling System to create or reuse a laser
			
				myLaser.transform.position = transform.position; // put this laser where the player is located
				
                ammo--;
            }
        }
    }
}
