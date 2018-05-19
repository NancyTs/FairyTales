using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PickableItem : MonoBehaviour
{

	public int itemID;
	public GameObject food;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnUse()
	{
		GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>().pickupItem();
		if(food)
			food.SetActive(false);
		Destroy(gameObject);
	}
}
