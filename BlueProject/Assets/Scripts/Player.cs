using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float speed = 12f;

    private Vector2 screenTop;
    private Vector2 screenBottom;

    private float shipHeight;
    private float shipWidth;

	// Use this for initialization
	void Start () {
        this.screenBottom = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        this.screenTop = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        this.shipHeight = transform.localScale.y / 2;
        this.shipWidth = transform.localScale.x / 2;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.isDead == false) {
            if (Input.GetButton("Vertical")) {
                float move = Input.GetAxis("Vertical") * Time.deltaTime * this.speed;
                float shipY = transform.position.y;

                if (shipY > this.screenTop.y - this.shipHeight && move > 0) {
                    move = 0;
                }

                if (shipY < this.screenBottom.y + this.shipHeight && move < 0) {
                    move = 0;
                }

                transform.Translate(move * Vector2.up);
                //Debug.Log(shipY + " " + this.screenTop.y + " " + this.screenBottom.y);
            }

            if (Input.GetButton("Horizontal")) {
                float move = Input.GetAxis("Horizontal") * Time.deltaTime * this.speed;
                float shipX = transform.position.x;

                if (shipX > this.screenTop.x - this.shipWidth && move > 0) {
                    move = 0;
                }

                if (shipX < this.screenBottom.x + this.shipWidth && move < 0) {
                    move = 0;
                }

                transform.Translate(move * Vector2.right);
                //Debug.Log(shipY + " " + this.screenTop.y + " " + this.screenBottom.y);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D coll) {
        //Debug.Log(coll.gameObject.tag);
        if (coll.gameObject.tag == "Enemy") {
            GameController.instance.PlayerCrash();
            this.gameObject.GetComponent<Animator>().CrossFade("Explosion",0);
            //this.gameObject.SetActive(false);
        }
    }
    
}
