using System.Collections;
using System.Collections.Generic;
using Core.Combat;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed = 1;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private  SpriteRenderer render;
    [SerializeField]
    private Collider2D collide;
	public float trailDelay = 3f;
    private bool stillRunning = false; //to check if the coroutine is stil running
    private bool hit = false;

    void Start()
    {
        collide = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        GetComponent<Projectile>().Deactivate = Hit;
        trailDelay = GetComponent<TrailRenderer>().time;
    }

    void OnEnable()
    {
        if (stillRunning) StopCoroutine("Deactivate");
        stillRunning = false;
        //StartCoroutine(Deactivate(destroyDelay)); // Deactivate this bullet after the specified seconds
        hit = false;
        render.enabled = true;
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.velocity = Vector2.zero;
    }	
   
    void FixedUpdate()
    {
        if (!hit)
        {
            rb.AddForce(speed * Time.fixedDeltaTime * Vector2.right);
        }
    }

    void Hit()
    {
        hit = true;
        render.enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
        Deactivate(trailDelay);
    }

    IEnumerator Deactivate(float delay)
    {
        stillRunning = true;
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
        stillRunning = false;
        yield return null;
    }
}
