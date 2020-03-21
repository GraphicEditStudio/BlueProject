using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceItemScroll : MonoBehaviour {

    private Rigidbody2D rbSpaceItem;
    private int minSpeed = 1;
    private int maxSpeed = 15;


	// Use this for initialization
	void Start () {
        int speed = Random.Range(minSpeed, maxSpeed);
        rbSpaceItem = GetComponent<Rigidbody2D>();
        rbSpaceItem.velocity = new Vector2(-speed, 0);
	}
	
}
