using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_C_1_Move : MonoBehaviour {


	public Transform ObjectA;
	public Transform ObjectB;
	public Transform ObjectC;
	private int ready = 0;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		int move = Camera_Signal_1.Move;

		if (move == 1) {
			if (ready == 0) {
				ready = 1;
				// 0.98 X, 0 Y, -10 Z
				ObjectA.transform.position = ObjectB.transform.position;

			}
		}
		if (ready == 1) {
			int counting = 0;
			int waitTime = 600; //120 = 1 sec || 600: 5 sec
			if (counting != waitTime + 1) {
				counting = counting + 1;

				ObjectA.transform.position = ObjectC.transform.position;
		}

	}
}
}