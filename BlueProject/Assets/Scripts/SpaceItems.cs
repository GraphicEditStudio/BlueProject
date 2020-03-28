using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlueGame;

public class SpaceItems : MonoBehaviour {
    PoolerManager pooler;
    GameObject spaceitem;

    public float spawnRate = 2f;
    private float minSpawnY = -4f;
    private float maxSpawnY = 4f;
    private float spawnX = 10.5f;

    private float scaleMin = 0.10f;
    private float scaleMax = 1.0f;
    private int rotateMin = 0;
    private int rotateMax = 359;
	
	private float spawnY;
	private float adjScale;
	private float adjRotation;

	// Use this for initialization
	void Start () {
        pooler = PoolerManager.instance;
        StartCoroutine(SpawnItems(spawnRate));
    }
    IEnumerator SpawnItems(float waitTime)
    {
        while (true)
        {
            spawnY = Random.Range(minSpawnY, maxSpawnY);
            adjScale = Random.Range(scaleMin, scaleMax);
            adjRotation = Random.Range(rotateMin, rotateMax);

            spaceitem = pooler.Spawn("SpaceItems", new Vector2(spawnX, spawnY), Quaternion.Euler(0, 0, adjRotation));
            spaceitem.transform.localScale = new Vector3(adjScale, adjScale, 1);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
