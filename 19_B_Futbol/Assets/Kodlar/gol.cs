using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gol : MonoBehaviour
{
	public AudioClip[] sesler;
						void OnTriggerEnter (Collider nesne)
						{
							if (nesne.gameObject.tag =="top")
							{
								Debug.Log ("GOOOOOOoooolll");
							}
						}
/*	void OnCollisionEnter(Collision nesne){
		if (nesne.gameObject.tag =="top")
		{
			GetComponent<AudioSource > ().PlayOneShot (sesler [1]);	
			Debug.Log ("Goooooolllll");
		}
	}
   
*/
	// Update is called once per frame
    void Update()
    {
        
    }
}
