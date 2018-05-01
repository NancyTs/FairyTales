using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharge : MonoBehaviour
{

	public int speed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
		
	}
}
