using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

	public float speed = 1;
    Rigidbody2D rb;
    public float destroyDelay = 4f;
	
	
	void Start()
    {
        //Destroy(gameObject, 3f);
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = (speed * Vector2.right);
    }
	
    void OnEnable()
    {
        
        Invoke("Deactivate", destroyDelay); // Deactivate this bullet after the specified seconds
    }	
	
	    void Update()
    {
        
        //transform.Translate(Vector3.forward * speed * Time.deltaTime); // Move the bullet forwards
		rb.velocity = (speed * Vector2.right);
    }
	
	    void Deactivate()
    {
       
        gameObject.SetActive(false);  // Deactivate this bullet
    }
	
	
	
}
