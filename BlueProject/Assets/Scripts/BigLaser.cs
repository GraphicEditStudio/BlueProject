using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigLaser : MonoBehaviour {

	public Transform fireStartPoint;
	public Transform fireEndPoint;
	public GameObject impactEffect;
	private LineRenderer LaserLine;
	private WaitForSeconds ShotDuration = new WaitForSeconds(0.07f);
	private RaycastHit2D HitInfo;
 
    void Start () {
	
	LaserLine = GetComponent<LineRenderer>();
	
    }

	   void  FixedUpdate () 
	  //void  Update ()
	
	{
		
		if (Input.GetButtonDown("Fire2"))
		{
			     StartCoroutine(ShotEffect());

			  HitInfo = Physics2D.Linecast(fireStartPoint.position, fireEndPoint.position);
			  
		  if (HitInfo.collider)
			{

				     Instantiate(impactEffect, HitInfo.point, Quaternion.identity);
			   
				 LaserLine.SetPosition(1, new Vector2(HitInfo.distance, -0.21f));
					
					//Debug.Log("hit!: " + HitInfo.distance.ToString());
		
			} 
			 else
			{

				LaserLine.SetPosition(1, (fireEndPoint.right * 1000f));
				
					//Debug.Log("NOThit!: ");
			}
			
		}
	}


    private IEnumerator ShotEffect()
    {
        LaserLine.enabled = true;
        yield return ShotDuration;
        LaserLine.enabled = false;
    }


}
