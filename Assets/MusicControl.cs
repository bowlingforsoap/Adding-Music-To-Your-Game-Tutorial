using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class MusicControl : MonoBehaviour {

	public AudioMixerSnapshot house;
	public AudioMixerSnapshot dog;
	public AudioSource stingSource;
	public AudioClip[] stings;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider coll) {
		if (coll.CompareTag("BarkingZone")) {
			dog.TransitionTo(1f); // in seconds
			PlaySting();
		}
	}

	void OnTriggerExit(Collider coll) {
		if (coll.CompareTag("BarkingZone")) {
			house.TransitionTo(1f);
		}
	}

	private void PlaySting() {
		int sting = Random.Range(0, stings.Length);
		stingSource.clip = stings[sting];
		stingSource.Play();
	}
}
