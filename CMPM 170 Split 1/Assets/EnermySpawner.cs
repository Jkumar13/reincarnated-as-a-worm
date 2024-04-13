using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;
	public float spawnRate = 5;
	private float timer = 0;
	public float heightOffset = 10;

	void Start () {
        spawnEnemy();
	}
	
	void Update () {
        if(timer < spawnRate) {
			timer = timer + Time.deltaTime;
		}
		else {
			spawnEnemy();
			timer = 0;
		}
	}

	void spawnEnemy(){
		float lowestPoint = transform.position.y - heightOffset;
		float highestPoint = transform.position.y + heightOffset;

		Instantiate(enemy, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
		transform.rotation);
	}
}