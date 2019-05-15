using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bars : MonoBehaviour
{
	Transform bar;

	void Start()
	{
		bar = transform.Find("Bar");
	}

	public void setSize(float sizeNormalized)
	{
		bar.localScale = new Vector3(sizeNormalized, 1f);
	}
}
