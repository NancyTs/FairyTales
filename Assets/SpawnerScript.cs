using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

	public GameObject prefab;
	private float spawnRate = 0.9f;
	private float spawnTimer = 0;
	private float gameTimer = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		spawnTimer -= Time.deltaTime;
		gameTimer -= Time.deltaTime;
		if (gameTimer > 0)
		{
			if (spawnTimer <= 0)
			{
				spawnTimer = spawnRate;
				Vector3 spawnPosition = transform.position;
				spawnPosition.z -= Random.Range(0f, 10f);
				Instantiate(prefab, spawnPosition, transform.rotation);
			}
		}
		else
		{
			GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>().StopShootingGame();
		}

	}
}
