using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceItemScroll : MonoBehaviour {

    private Rigidbody2D rbSpaceItem;
    private float minSpeed = 5;
    private float maxSpeed = 15;


    // Use this for initialization
    private void Awake()
    {
        rbSpaceItem = GetComponent<Rigidbody2D>();
    }
    void OnEnable () {
        float speed = Random.Range(minSpeed, maxSpeed);
        rbSpaceItem.velocity = new Vector2(-speed, 0);
	}
	
}
