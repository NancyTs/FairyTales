using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class TurnUsableOn : MonoBehaviour
{

	private SphereCollider usableScript;

	// Use this for initialization
	void Start ()
	{

		usableScript = GetComponent<SphereCollider>();
		usableScript.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void usableOn()
	{
		usableScript.enabled = true;
	}
}
