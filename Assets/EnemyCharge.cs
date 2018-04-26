using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharge : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * 8 * Time.deltaTime);
		
	}
}
