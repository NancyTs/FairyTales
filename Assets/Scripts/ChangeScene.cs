using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
	//name of the scene you want to load
	public string scene;
	public Color loadToColor = Color.white;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeScene()
	{
		Initiate.Fade(scene,loadToColor,0.5f);	
	}
}
