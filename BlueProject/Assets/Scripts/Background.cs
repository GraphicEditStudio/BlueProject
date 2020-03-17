using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {


    public float BgSpeed = 0.3f;
    private Renderer BgRenderer;
    SpriteRenderer playerRenderer;


    // Use this for initialization
    void Start ()
    {
        BgRenderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            BgRenderer.material.mainTextureOffset += new Vector2(-BgSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            BgRenderer.material.mainTextureOffset += new Vector2(BgSpeed * Time.deltaTime, 0f);
        }

        float speed = Input.GetAxis("Horizontal");
        BgRenderer.material.mainTextureOffset += new Vector2(speed  * Time.deltaTime, 0f);

        if (speed * Time.deltaTime < 0)
        {

        }
            //Movement.playerRenderer.flipX = true;

        if (speed * Time.deltaTime > 0)
        {

        }
            //Movement.playerRenderer.flipX = false;


    }
}
