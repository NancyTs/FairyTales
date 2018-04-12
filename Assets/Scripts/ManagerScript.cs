using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
	public GameObject bookIcon;
	private bool inBookTrigger = false;
	private bool inBookCanvas = false;
	public GameObject bookCanvas;
	public GameObject player;
	public List<int> itemsPicked;

	// Use this for initialization
	void Start () {
		bookCanvas.SetActive(false);
		bookIcon = GameObject.FindGameObjectWithTag("BookIcon");
		bookIcon.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.B) && inBookCanvas)
		{
			bookCanvas.SetActive(false);
			inBookCanvas = false;
			player.GetComponent<SetComponentEnabledCustom>().enableComponents();
			DialogueManager.Instance.StopConversation();
		}
		else if(Input.GetKeyDown(KeyCode.B) && inBookTrigger && !inBookCanvas)
		{
			bookCanvas.SetActive(true);
			inBookCanvas = true;
			player.GetComponent<SetComponentEnabledCustom>().disableComponents();
		}
		
	}

	public void EnableBookIcon(int convID)
	{
		bookCanvas.GetComponentInChildren<SetText>().setText(convID);
		bookIcon.SetActive(true);
		inBookTrigger = true;
	}
	
	public void DisableBookIcon()
	{
		bookIcon.SetActive(false);
		inBookTrigger = false;
	}

	public void exitBook()
	{
		if (inBookCanvas)
		{
			bookCanvas.SetActive(false);
			inBookCanvas = false;
			player.GetComponent<SetComponentEnabledCustom>().enableComponents();
			DialogueManager.Instance.StopConversation();
		}
	}

	public void pickupItem(int id)
	{
		itemsPicked.Add(id);
	}

	public bool checkItem(int id)
	{
		return itemsPicked.Contains(id);
	}

	public bool checkRequiredItems(List<int> requiredItems)
	{
		foreach (int item in requiredItems)
		{
			if (!itemsPicked.Contains(item))
				return false;
		}
		return true;
	}
}
