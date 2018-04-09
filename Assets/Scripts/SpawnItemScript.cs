using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItemScript : MonoBehaviour
{

	public GameObject[] options;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void spawn(string id)
	{
		int ID = Int32.Parse(id);
		Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position;
		//Instantiate(options[ID], pos, Quaternion.identity);
		options[ID].SetActive(true);
		//options[ID].GetComponent<SphereCollider>().enabled = true;
		//options[ID].transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
		this.gameObject.SetActive(false);
		GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>().DisableBookIcon();
	}
	
	
}
