using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {
    public float Health;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit Successful!");
    }
}