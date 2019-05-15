using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	public float lifetime = 10f;
	public Transform spawnPos;
	public GameObject particle;
	
	void Update () {

		if (lifetime > 0)
		{
			lifetime -= Time.deltaTime;

			if (lifetime <= 0){
				Destruction();
			}
		}
	}

	void OnCollisionEnter(Collision collision){

		if (collision.gameObject.name == "Player" || collision.gameObject.name == "BackGround"){
			Destruction();
			Instantiate(particle, spawnPos.position, spawnPos.rotation);
		}
	}

	void Destruction(){

		Destroy(this.gameObject);
	}
}
