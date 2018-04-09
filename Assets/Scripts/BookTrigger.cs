using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookTrigger : MonoBehaviour
{
	private bool inBookTrigger = false;
	public int convID;
	public int completedConvID;
	public int[] requiredItems;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnTriggerEnter(Collider other)
	{
		inBookTrigger = true;
		if (checkCondition())
		{
			GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>().EnableBookIcon(completedConvID);
			//do something to move forward
			
		}
		else
			GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>().EnableBookIcon(convID);
		

	}
	
	private void OnTriggerExit(Collider other)
	{
		GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>().DisableBookIcon();
		inBookTrigger = false;
	}

	public bool checkCondition()
	{
		bool hasItems = false;
		foreach (int requiredItem in requiredItems)
		{
			if (!GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>().checkItem(requiredItem))
				return false;

		}
		return true;
	}
	
	
}
