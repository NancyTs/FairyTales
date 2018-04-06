using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFacePlayer : MonoBehaviour {
	
	
	Vector3 playerPos;
	Vector3 npcPos;

	// Use this for initialization
	void Start ()
	{


	}
	
	// Update is called once per frame
	void Update () {
		
		playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
		Vector3 delta = new Vector3(playerPos.x - transform.position.x, 0.0f, playerPos.z - transform.position.z);
		Quaternion rotation = Quaternion.LookRotation(delta);
		transform.rotation = rotation;

	}
	
 
}
