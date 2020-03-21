using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    void Start()
    {
        Destroy(gameObject, 3f);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = (speed * Vector2.right);
    }
}
