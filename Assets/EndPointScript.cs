using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPointScript : MonoBehaviour
{
	private int counter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Boar")
		{
			Destroy(other.gameObject);
			counter++;
		}
	}
}
