using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour
{
	public int ItemsPicked = 0;
	public int ItemsCollected = 0;
	public int ItemsShot = 0;
	public Text totalText;
	public Text shotText;
	public Text collectedText;

	// Use this for initialization
	void Start () {
		
		Cursor.visible = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}


	public void pickupItem()
	{
		ItemsPicked++;
		ItemsCollected++;
		totalText.text = ItemsPicked.ToString();
		collectedText.text = ItemsCollected.ToString();
	}
	
	public void shootItem()
	{
		ItemsPicked++;
		ItemsShot++;
		totalText.text = ItemsPicked.ToString();
		shotText.text = ItemsShot.ToString();
	}

	public int checkItem()
	{
		return ItemsPicked;
	}

}
