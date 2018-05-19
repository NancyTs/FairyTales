using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour
{
	public int ItemsPicked = 0;
	public Text text;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}


	public void pickupItem()
	{
		ItemsPicked++;
		text.text = ItemsPicked.ToString();
	}

	public int checkItem()
	{
		return ItemsPicked;
	}

	public bool checkRequiredItems()
	{
		if (ItemsPicked >= 5)
				return true;
		
		return false;
	}
}
