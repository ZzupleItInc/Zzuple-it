using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Appear_Open : MonoBehaviour {


	public int Appear = 0;
	public int Equipped = 0;
		


	// Use this for initialization
	void Start () {

		GetComponent<SpriteRenderer> ().enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Appear != 0)
			GetComponent<SpriteRenderer> ().enabled = false;

		{

		

		}
		
	}
}
