// Smooth towards the target

using UnityEngine;
using System.Collections;

public class Camera_Move_1 : MonoBehaviour
{
	public Transform target;
	public Transform original;
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;
	private int done = 0;

	void Start(){
		
	
	}



	void Update()
	{
		if (done != 60) {
			done = done + 1;
		// Define a target position above and behind the target transform
		Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));
		//Vector3 originalPosition = original.TransformPoint(new Vector3(0, 5, -10));


		// Smoothly move the camera towards that target position
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
			if (done == 59) {
				GetComponent<Camera_Move_2> ().enabled = true;

			}
			
		//transform.position = Vector3.SmoothDamp(transform.position, originalPosition, ref velocity, smoothTime);
		
		}
	}

}

