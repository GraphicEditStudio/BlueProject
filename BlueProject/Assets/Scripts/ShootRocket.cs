using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using BlueGame;
using Core.Combat;

public class ShootRocket : MonoBehaviour
{
    GameController controller;

	public int ammo;
	public float cooldown;
	
    [SerializeField]
	private KeyCode rocket = KeyCode.Space;
	
	float shootTime = 0;
	
	public Vector2 initForce;

	private PoolerManager pooler;	
	
    void Start()
    {
        controller = GameController.instance;
        pooler = PoolerManager.instance; // Pooler Manager 
    }
	
    void Update()
    {
        if (controller.isPaused) return;
        if (ammo > 0 && Input.GetKeyDown(rocket))
        {
            if (Time.time > shootTime + cooldown)
            {
                shootTime = Time.time;
				
				GameObject myRocket = pooler.Spawn("PRocket", transform.position, Quaternion.identity); // Pooling System to create or reuse a rocket
                
                myRocket.GetComponent<Projectile>().parent = transform.parent.gameObject;
                myRocket.GetComponent<Rigidbody2D>().AddForce(initForce, ForceMode2D.Impulse);
                AudioManager.instance.Play("RocketShoot");

                ammo--;
            }
        }
    }
}
