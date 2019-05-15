using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
	public float speed = 0.5f;

	void Update()
	{
		Vector2 offset = new Vector2(Time.time * speed, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
