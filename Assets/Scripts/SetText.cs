using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class SetText : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setText(int id)
	{
		
		var entry = DialogueManager.MasterDatabase.GetConversation(id).Title;
		GetComponent<ConversationTrigger>().conversation = entry;
	}
}
