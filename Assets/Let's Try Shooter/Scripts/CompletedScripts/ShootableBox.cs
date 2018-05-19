using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootableBox : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 1;

	private GameManagerScript manager;

	private void Start()
	{
		//manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
	}

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;

		//Check if health has fallen below zero
		if (currentHealth <= 0) 
		{
			//if health has fallen below zero, deactivate it 
			//manager.shotTarget();
			Destroy(gameObject);
			GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>().pickupItem();
		}
	}

	public void OnCollisionEnter(Collision collider)
	{
		if (collider.gameObject.name == "EndPoint")
		{
			manager.missedTarget();
			Destroy(gameObject);
		}
	}
}
