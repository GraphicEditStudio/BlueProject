using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlueGame2;

public class ShootRocket : MonoBehaviour
{
    //public GameObject rocketPrefab;
	public int ammo;
	public float cooldown;
	
	KeyCode rocket = KeyCode.Space;
	
	float shootTime = 0;
	
	//public Vector2 initForce;
 
	public int rocketOnStart = 0; // The number of rocket to immediately instantiate when the game starts
	private MainPoolB rocketPooler;	
	
    void Start()
    {
        
        rocketPooler = GeneralPoolerManagerB.GetObjectPooler(0); // Pooler Manager 
		
        if (rocketOnStart > 0) rocketPooler.InitializePool(rocketOnStart); //how many bullets
    }	
	
	
    void Update()
    {
        if (ammo > 0 && Input.GetKeyDown(rocket))
        {
            if (Time.time > shootTime + cooldown)
            {
                shootTime = Time.time;
                
				//Instantiate(rocketPrefab, transform).GetComponent<Rigidbody2D>().AddForce(initForce, ForceMode2D.Impulse);
				
				GameObject myRocket = rocketPooler.GetObject(); // Pooling System to create or reuse a rocket
			
				myRocket.transform.position = transform.position; // put this rocket where the player is located
			
                ammo--;
            }
        }
    }
}
