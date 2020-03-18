using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float speed = 12f;

    bool moveup = false;
    bool movedown = false;
    float lastshot = 0;
    public static bool isShooting = false;

    public SpriteRenderer ShipRenderer;

    public Transform Projectile;

    // Use this for initialization
    void Start ()
    {
        ShipRenderer.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (GameController.instance.isDead == false)
        {
            if ((Input.GetAxisRaw("Vertical") > 0) && (transform.position.y <= 4.4f))
            {
                
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if ((Input.GetAxisRaw("Vertical") < 0) && (transform.position.y >= -4.4f))
            {
                
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
             
            if ((Input.GetAxisRaw("Horizontal") > 0) && (transform.position.x >= -7))
            {
                ShipRenderer.flipX = false;
                ProjectileScript.flipX = false;
                transform.Translate(Vector3.left * speed * 1.5f * Time.deltaTime);
            }
            else if ((Input.GetAxisRaw("Horizontal") < 0) && (transform.position.x <= 7))
            {
                transform.Translate(Vector3.right * speed * 1.5f * Time.deltaTime);
                ShipRenderer.flipX = true;
                ProjectileScript.flipX = true;
            }
            else if (Input.GetAxisRaw("Horizontal") == 0)
            {
                if (transform.position.x != 0)
                {                   
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y, transform.position.z), speed * 1.5f * Time.deltaTime);
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                isShooting = true;
            }

            if ((Time.time - lastshot > 0.5f) && (isShooting))
            {
                if (!HeatBar.BarEmpty)
                {
                    isShooting = true;
                    if (!ShipRenderer.flipX)
                    {
                        Instantiate(Projectile, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(Projectile, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), Quaternion.identity);
                    }
                }

                lastshot = Time.time;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                isShooting = false;
            }
            
        }
    }

    /*private void OnTriggerEnter2D(Collider2D coll) {
        //Debug.Log(coll.gameObject.tag);
        if (coll.gameObject.tag == "Enemy") {
            GameController.instance.PlayerCrash();
            this.gameObject.GetComponent<Animator>().CrossFade("Explosion",0);
            //this.gameObject.SetActive(false);
        }
        
    }
    */
    
}
