using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vur : MonoBehaviour
{
    void OnTriggerEnter (Collider nesne)
	{
		if (nesne.gameObject.tag =="top")
		{
			Debug.Log ("Topa Değdik");
			transform.root.gameObject.GetComponent<Karakter> ().top = true;
		}
	}

	void OnTriggerExit (Collider nesne)
	{
		if (nesne.gameObject.tag =="top")
		{
			Debug.Log ("Topa Çıktık");
			transform.root.gameObject.GetComponent<Karakter> ().top = false;
		}
	}

	void OnTriggerStay (Collider nesne)
	{
		if (nesne.gameObject.tag =="top")
		{
			Debug.Log ("Topa Çıktık");
			transform.root.gameObject.GetComponent<Karakter> ().top = false;
		}
	}
}
