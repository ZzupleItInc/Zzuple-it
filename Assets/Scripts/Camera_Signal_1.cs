using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Signal_1 : MonoBehaviour {





	public static int Move = 0;
	public int p_Move = 0;
	private int CM1On = 0;

	// Use this for initialization
	void Start () {



		GetComponent<Camera_Move_1>().enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
		p_Move = Move;
		// Move = p_Move; //use for testing
		if (Move == 1) {
			if (CM1On == 0) {
				CM1On = 1;
				GetComponent<Camera_Move_1> ().enabled = true;

			}
		}
	}
}



