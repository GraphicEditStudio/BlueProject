using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    void Start()
    {
        Destroy(gameObject, 3f);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(speed * Time.fixedDeltaTime * Vector2.right);
    }
}
