using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
	public AudioMixer audiomixer;

	public void SetLevel(float volume)
	{
		audiomixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
	}
}
