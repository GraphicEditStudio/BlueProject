using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rb;
	public float destroyDelay = 4f;
	
    void Start()
    {
        //Destroy(gameObject, 3f);
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
    
        Invoke("Deactivate", destroyDelay); // Deactivate this bullet after the specified seconds
    }	
   
    void Update()
    {
        //rb.AddForce(speed * Time.fixedDeltaTime * Vector2.right);
		rb.velocity = (speed * Vector2.right);
    }
	
	void Deactivate()
    {
       
        gameObject.SetActive(false);  
    }	
	
}
