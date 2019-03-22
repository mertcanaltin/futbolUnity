using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{
	public AudioClip[] sesler;

	void OnCollisionEnter(Collision nesne){
		if (nesne.gameObject.tag =="Kale")
		{
			GetComponent<AudioSource > ().PlayOneShot (sesler [3]);	
			Debug.Log ("kkkkkkkaaaaalllllleeeee");
		}if (nesne.gameObject.tag =="direk")
		{
			GetComponent<AudioSource > ().PlayOneShot (sesler [2]);	
			Debug.Log ("direeeeeeekkkkk");
		}
	}
}