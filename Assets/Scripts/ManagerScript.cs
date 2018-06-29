using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour
{
	public int ItemsPicked = 0;
	public int ItemsCollected = 0;
	public int ItemsShot = 0;
	public Text totalText;
	public Text shotText;
	public Text collectedText;
	public int missedTargets;

	// Use this for initialization
	void Start () {
		
		Scene m_Scene = SceneManager.GetActiveScene();

		//Check if the current Active Scene's name is your first Scene
		if (m_Scene.name != "bravery")
		Cursor.visible = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	
	public void missedTarget()
	{
		missedTargets++;
	}

	public void pickupItem()
	{
		ItemsPicked++;
		ItemsCollected++;
		if(totalText)
			totalText.text = ItemsPicked.ToString();
		if(collectedText)
			collectedText.text = ItemsCollected.ToString();
	}
	
	public void shootItem()
	{
		ItemsPicked++;
		ItemsShot++;
		if(totalText)
		totalText.text = ItemsPicked.ToString();
		if(shotText)
		shotText.text = ItemsShot.ToString();
	}

	public int checkItem()
	{
		return ItemsPicked;
	}

}
