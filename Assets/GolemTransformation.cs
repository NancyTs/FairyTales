using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemTransformation : MonoBehaviour
{

	public GameObject golem;
	public GameObject human;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void transform()
	{
		golem.SetActive(false);
		human.SetActive(true);
	}
}
