using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PetChooser : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int id = DialogueLua.GetVariable("Pet").AsInt;
		transform.GetChild(id).gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
