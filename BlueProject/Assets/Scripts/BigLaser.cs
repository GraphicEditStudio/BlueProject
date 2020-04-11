using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlueGame;

public class BigLaser : MonoBehaviour {

	[SerializeField] public Transform fireStartPoint;
	[SerializeField] public Transform fireEndPoint;
	[SerializeField] public string diedVFXName;
	
	private LineRenderer LaserLine;
	private WaitForSeconds ShotDuration = new WaitForSeconds(0.07f);
	private RaycastHit2D HitInfo;
	
    void Start () 
	{
	
	LaserLine = GetComponent<LineRenderer>();
	
    }

	 void  FixedUpdate () 
	 {
		
		if (Input.GetButtonDown("Fire2"))
		{
			     StartCoroutine(ShotEffect());

			  HitInfo = Physics2D.Linecast(fireStartPoint.position, fireEndPoint.position);
			  
		  if (HitInfo.collider)
			{

				     //TO DO detect enemy and destroy it.
					  PoolerManager.instance.Spawn(diedVFXName, HitInfo.point, Quaternion.identity);
			   
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
