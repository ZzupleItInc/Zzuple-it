using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Signal_1 : MonoBehaviour {





	public static int Move = 0;



	// Use this for initialization
	void Start () {



		GetComponent<Camera_Move_1>().enabled = false;


	}
	
	// Update is called once per frame
	void Update () {

		if (Move == 1) {
			GetComponent<Camera_Move_1> ().enabled = true;


				
		} 

	}
}
