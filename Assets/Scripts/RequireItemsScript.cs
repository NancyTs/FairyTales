using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequireItemsScript : MonoBehaviour
{

	public List<int> itemsRequired;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnUse()
	{
		
		GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>().checkRequiredItems(itemsRequired);
	}
}
