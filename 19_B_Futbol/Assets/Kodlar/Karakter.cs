using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
	public bool top;
	public GameObject topobj;
	public float sut1, sut2, hava1, hava2;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown (0)) {
			topobj.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3 (0,0,7));
		}
		if (Input.GetMouseButtonDown (1)) {
			topobj.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3 (0,Random.Range(hava1,hava2),Random.Range(sut1,sut2)));
		} 
    }
}
