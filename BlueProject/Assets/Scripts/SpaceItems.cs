using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceItems : MonoBehaviour {

    public GameObject spaceitemPrefab;

    private GameObject[] spaceitems;

    private int maxspaceitems = 40;
    private float spawnRate = 1f;
    private float minSpawnY = -4f;
    private float maxSpawnY = 4f;
    private float spawnX = 12.0f;
    private int recentAstroid = 0;

    private float scaleMin = 0.10f;
    private float scaleMax = 1.0f;
    private int rotateMin = 0;
    private int rotateMax = 359;
	
	private float spawnY;
	private float adjScale;
	private float adjRotation;

	// Use this for initialization
	void Start () {
        Vector2 startPos = new Vector2(20, 20);
        spaceitems = new GameObject[maxspaceitems];
        for (int i = 0; i < maxspaceitems; i++) {
            spaceitems[i] = Instantiate(spaceitemPrefab, startPos, Quaternion.identity);
        }
        StartCoroutine(SpawnItems(spawnRate));
    }
    IEnumerator SpawnItems(float waitTime)
    {
        while (true)
        {
            spawnY = Random.Range(minSpawnY, maxSpawnY);
            adjScale = Random.Range(scaleMin, scaleMax);
            adjRotation = Random.Range(rotateMin, rotateMax);

            spaceitems[recentAstroid].transform.position = new Vector2(spawnX, spawnY); // set spawn position
            spaceitems[recentAstroid].transform.localScale = new Vector3(adjScale, adjScale, 1); // change items scale 
            spaceitems[recentAstroid].transform.Rotate(0, 0, adjRotation); // rotate items 

            recentAstroid++;

            if (recentAstroid >= maxspaceitems)
            {
                recentAstroid = 0;
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}
