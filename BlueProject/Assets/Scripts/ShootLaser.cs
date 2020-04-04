using System.Collections;
using System.Collections.Generic;
using Audio;
using Core.Combat;
using UnityEngine;
using BlueGame;

public class ShootLaser : MonoBehaviour
{
    public int initialAmmo = 1000;
    public int ammoType = 0; //check Player.cs for types
    public float cooldown;
    
    [SerializeField]
	private KeyCode laser = KeyCode.Mouse0;
	
	float shootTime = 0;

    private PoolerManager pooler;
    private GameController controller;
    private Player player;
    private AudioManager audioManager;

    void Start()
    {
        audioManager = AudioManager.instance;
        player = Player.instance;
        controller = GameController.instance;
        pooler = PoolerManager.instance;
        player.ammo[ammoType] = initialAmmo;
    }

	
	void Update()
    {
        if (controller.isPaused) return;
        if (player.ammo[ammoType] > 0 && Input.GetKey(laser))
        {
            if (Time.time > shootTime + cooldown)
            {
                shootTime = Time.time;

                GameObject myLaser = pooler.Spawn("PLaser", transform.position, Quaternion.identity);  // Pooling System to create or reuse a laser
                myLaser.GetComponent<Projectile>().parent = transform.parent.gameObject;
                audioManager.Play("LaserShoot");
                player.ammo[ammoType]--;
            }
        }
    }
}
