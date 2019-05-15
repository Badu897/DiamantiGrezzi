using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollisions : MonoBehaviour
{
	[SerializeField] private Bars healthBar;
	[SerializeField] private Bars hungerBar;
	const float damage = 0.2f;
	const float bite = 0.1f;
	float n = 0;
	private float nCollisionsSun = -damage;
	private float nCollisionsPlanet = bite;

	void OnCollisionEnter(Collision collision){

		if (collision.gameObject.name == "Sun(Clone)"){

			healthBar.setSize(1 + nCollisionsSun);
			nCollisionsSun -= damage;
			FindObjectOfType<AudioManager>().Play("DamageSound");

			if (nCollisionsSun == -1.2f)
			{
				FindObjectOfType<AudioManager>().Stop("MainTheme");
				FindObjectOfType<AudioManager>().Play("DeathSound");
				SceneManager.LoadScene(2);
			}
		}

		if(collision.gameObject.name == "Planet(Clone)"){

			FindObjectOfType<AudioManager>().Play("PopSound");
			hungerBar.setSize(nCollisionsPlanet);
			nCollisionsPlanet += bite;
			n++;

			if (n == 11)
			{
				FindObjectOfType<AudioManager>().Play("HealthSound");
				hungerBar.setSize(0);
				healthBar.setSize(1);
				nCollisionsPlanet = bite;
				n = 0;
				nCollisionsSun = -damage;
				nCollisionsPlanet = bite;
			}
		}
	}
}
