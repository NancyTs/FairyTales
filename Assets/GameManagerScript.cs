using System;
using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class GameManagerScript : MonoBehaviour
{
	public GameObject SlidePuzzle1;
	public GameObject Instructions;
	public GameObject brokenFence;
	public GameObject fixedFence;
	public GameObject AfterPuzzleConversation;
	public GameObject fpsGun;
	public GameObject UICamera;
	public GameObject Spawner;
	public GameObject BoarSequence;
	public GameObject ShootingGallery;
	public GameObject AfterTutorialConversation;
	public GameObject AfterSuccessConversation;
	public GameObject AfterFailConversation;
	public GameObject InstructionsConversation;
	public Text text;
	public int shotTargets;
	public int missedTargets;
	public int numSpawnTargets = 5;
	public int requiredSuccesses;
	public bool retryShooting = false;
	public int shootingStage = 0;
	

	// Use this for initialization
	void Start ()
	{
		//StartShootingGame();
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

	public void StartShootingGame()
	{
		enableComponents();
		Spawner.GetComponent<SpawnerScript>().pauseGame();
		//Trigger Tutorial conversation
		InstructionsConversation.SetActive(true);
		AfterSuccessConversation.SetActive(false);
		AfterTutorialConversation.SetActive(false);
		AfterFailConversation.SetActive(false);
		if (shootingStage == 0)
		{
			numSpawnTargets = 20;
			requiredSuccesses = 1;
			reset();
			Spawner.GetComponent<SpawnerScript>().setShootingParameters(numSpawnTargets, 20, 2f, 2f, 2f, 2f);
			//Spawner.GetComponent<SpawnerScript>().setShootingParameters(numSpawnTargets, 1000, 2f, 2f, 2f, 2f);
		}
		else if(shootingStage == 1)
		{
			numSpawnTargets = 6;
			requiredSuccesses = 3;
			reset();
			Spawner.GetComponent<SpawnerScript>().setShootingParameters(numSpawnTargets, 25, -3f, 3f, -8f, 8f);
			//Spawner.GetComponent<SpawnerScript>().setShootingParameters(numSpawnTargets, 1000, -3f, 3f, -8f, 8f);
			
		}
		else if(shootingStage == 2)
		{
			numSpawnTargets = 15;
			requiredSuccesses = 7;
			reset();
			Spawner.GetComponent<SpawnerScript>().setShootingParameters(numSpawnTargets, 30, -1f, 2f, -8f, 8f);
			//Spawner.GetComponent<SpawnerScript>().setShootingParameters(numSpawnTargets, 1100, -1f, 2f, -2f, 2f);
			
		}
		//BoarSequence.SetActive(false);
	}

	private void reset()
	{
		
		shotTargets = 0;
		text.text = shotTargets.ToString();
		missedTargets = 0;
	}

	void enableComponents()
	{
		
		Camera.main.GetComponent<Animator>().SetTrigger("FPS");
		fpsGun.SetActive(true);
		UICamera.SetActive(true);
		text = GameObject.FindGameObjectWithTag("KillCount").GetComponent<Text>();
		Spawner.SetActive(true);
		ShootingGallery.SetActive(true);
	}

	public void wonShooting()
	{
		Spawner.GetComponent<SpawnerScript>().pauseGame();
		if(shootingStage == 0)
			AfterTutorialConversation.SetActive(true);
		else
			AfterSuccessConversation.SetActive(true);
		shootingStage++;
		DialogueLua.SetVariable("ShootingStage", shootingStage);
		InstructionsConversation.SetActive(false);
	}

	public void lostShooting()
	{
		Spawner.GetComponent<SpawnerScript>().pauseGame();
		AfterFailConversation.SetActive(true);
		retryShooting = true;
		DialogueLua.SetVariable("RetryShoot", true);
		InstructionsConversation.SetActive(false);
	}

	public void StopShootingGame()
	{
		
		InstructionsConversation.SetActive(false);
		AfterSuccessConversation.SetActive(false);
		AfterTutorialConversation.SetActive(false);
		AfterFailConversation.SetActive(false);
		Camera.main.GetComponent<Animator>().SetTrigger("Follow");
		fpsGun.SetActive(false);
		UICamera.SetActive(false);
		Spawner.SetActive(false);
		ShootingGallery.SetActive(false);
	}

	public void shotTarget()
	{
		shotTargets++;
		text.text = shotTargets.ToString();
		if (shotTargets >= requiredSuccesses)
		{
			wonShooting();
		}
	}


}
