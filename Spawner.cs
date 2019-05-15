using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Transform spawnPos;
	public GameObject planet;
	public GameObject missile;
	const float spawnTime = 2;
	float pauseTime = spawnTime;

	void Update(){

		if (pauseTime <= 0)
		{
			Spawn();
			pauseTime = spawnTime;
		}
		else
		{
			pauseTime = pauseTime - Time.deltaTime;
		}
	}

	void Spawn(){

		if(Random.Range(1, 1000) <= 333)
		{
			Instantiate(planet, spawnPos.position, spawnPos.rotation);
		}
		else if(Random.Range(1, 1000) >= 666)
		{
			Instantiate(missile, spawnPos.position, spawnPos.rotation);
		}
	}
}
