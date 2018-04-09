using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class SetDialogueUI : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

		
		GetComponent<OverrideDisplaySettings>().displaySettings.dialogueUI = GameObject.FindGameObjectWithTag("BookUI");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
