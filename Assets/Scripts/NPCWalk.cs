using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalk : MonoBehaviour {

	private Vector3 speed = new Vector3(0, 0, 1);
	private Rigidbody rBody; 

	void Start(){

		rBody = GetComponent<Rigidbody> ();
	}
	void FixedUpdate() {
		rBody.MovePosition(rBody.position + speed);
	}
}
