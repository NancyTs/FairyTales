using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPointScript : MonoBehaviour
{
	private int counter;
	public GameManagerScript manager;

	// Use this for initialization
	private void Awake () {
		
		manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Shootable")
		{
			manager.missedTarget();
			Destroy(other.gameObject);
		}
	}
}
