using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastWeapon : MonoBehaviour {

	public Transform fireStartPoint;
	public Transform fireEndPoint;
	public GameObject impactEffect;
	
	private LineRenderer LaserLine;
	private WaitForSeconds ShotDuration = new WaitForSeconds(0.07f);
	
	private Vector3 TEST ;

    void Start () {
	
	LaserLine = GetComponent<LineRenderer>();
	
	LaserLine.SetPosition(0, fireStartPoint.position);
	LaserLine.SetPosition(1, fireEndPoint.position);
	
    }

	void Update () {
		
		if (Input.GetButtonDown("Fire2"))
		{
			StartCoroutine(ShotEffect());
			RaycastHit2D hitInfo = Physics2D.Raycast(fireStartPoint.position, fireStartPoint.right);

			if (hitInfo.collider)
			{

			 Instantiate(impactEffect, hitInfo.point, Quaternion.identity);
		 
			  TEST = new Vector3(hitInfo.point.x, -0.21f, 0f);
			 
			  //LaserLine.SetPosition(1, hitInfo.point);
			    LaserLine.SetPosition(1, TEST);
         

			} 
			 else
			{

			 LaserLine.SetPosition(1, fireEndPoint.position);
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
