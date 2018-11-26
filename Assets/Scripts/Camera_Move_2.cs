using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move_2 : MonoBehaviour {

	public Transform original;
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;
	int counting = 0;
	int waitTime = 600; //120 = 1 sec || 600: 5 sec
	// Use this for initialization
	void Start () {
		GetComponent<Camera_Move_1> ().enabled = false;

	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 targetPosition = original.TransformPoint(new Vector3(0, 5, -10));

		if (counting != waitTime + 1) {
			counting = counting + 1;
			transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
			print (counting);
			if (counting == 200) {
			
				GetComponent<Camera_Follow> ().enabled = true;
			
			}

		}


	}
}
