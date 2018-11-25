using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Move : MonoBehaviour {

	public Transform ObjectA;
	public Transform ObjectB;

	// Use this for initialization
	void Start () {
		

			
	}
	
	// Update is called once per frame
	void Update () {




	}
	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.collider.name == "Key") {
			ObjectA.transform.position = ObjectB.transform.position;

}
	}
}
