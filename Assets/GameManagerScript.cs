using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class GameManagerScript : MonoBehaviour
{
	public GameObject SlidePuzzle1;
	public GameObject Instructions;
	public GameObject brokenFence;
	public GameObject fixedFence;
	public GameObject AfterPuzzleConversation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartPuzzle()
	{
		Camera.main.GetComponent<DepthOfFieldDeprecated>().enabled = false;
		Camera.main.GetComponent<Animator>().SetTrigger("Puzzle");
		SlidePuzzle1.GetComponent<ST_PuzzleDisplay>().StartPuzzle();
		Instructions.SetActive(true);
	}

	public void StopPuzzle()
	{
		Camera.main.GetComponent<DepthOfFieldDeprecated>().enabled = true;
		Camera.main.GetComponent<Animator>().SetTrigger("Follow");
		Instructions.SetActive(false);
		brokenFence.SetActive(false);
		fixedFence.SetActive(true);
		AfterPuzzleConversation.SetActive(true);
	}

}
