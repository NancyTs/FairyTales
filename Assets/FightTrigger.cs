using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightTrigger : MonoBehaviour {
	
	public GameObject bounds;
	public GameObject newPosition;
	public GameObject spawner;
	public GameObject guard;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void trigger()
	{
		bounds.SetActive(true);
		spawner.SetActive(true);
		GameObject.FindGameObjectWithTag("Player").transform.position = newPosition.transform.position;
		GameObject.FindGameObjectWithTag("Player").transform.rotation = newPosition.transform.rotation;
		Cursor.visible = false;
		Destroy(guard);
	}
}
