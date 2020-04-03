using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using BlueGame;
using Core.Combat;

public class ShootRocket : MonoBehaviour
{
    public int initialAmmo = 8;
    public int ammoType = 1; //check Player.cs for types
	public float cooldown;
	
    [SerializeField]
	private KeyCode rocket = KeyCode.Space;
	
	float shootTime = 0;
	
	public Vector2 initForce;

	private PoolerManager pooler;
    private GameController controller;
    private Player player;
    private AudioManager audioManager;

    void Start()
    {
        audioManager = AudioManager.instance;
        player = Player.instance;
        controller = GameController.instance;
        pooler = PoolerManager.instance; // Pooler Manager
        player.ammo[ammoType] = initialAmmo;
        DisplayStats.UpdateRocketAmmo(initialAmmo);
    }
	
    void Update()
    {
        if (controller.isPaused) return;
        if (player.ammo[ammoType] > 0 && Input.GetKeyDown(rocket))
        {
            if (Time.time > shootTime + cooldown)
            {
                shootTime = Time.time;
				
				GameObject myRocket = pooler.Spawn("PRocket", transform.position, Quaternion.identity); // Pooling System to create or reuse a rocket
                
                myRocket.GetComponent<Projectile>().parent = transform.parent.gameObject;
                myRocket.GetComponent<Rigidbody2D>().AddForce(initForce, ForceMode2D.Impulse);
                audioManager.Play("RocketShoot");

                player.ammo[ammoType]--;
                DisplayStats.UpdateRocketAmmo(player.ammo[ammoType]);
            }
        }
    }
}
