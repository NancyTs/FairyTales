using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootableBox : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 3;
	public Text text;
	private int counter;

	private void Start()
	{
		text = GameObject.FindGameObjectWithTag("KillCount").GetComponent<Text>();
	}

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;

		//Check if health has fallen below zero
		if (currentHealth <= 0) 
		{
			//if health has fallen below zero, deactivate it 
			gameObject.SetActive (false);
			counter = Int32.Parse(text.text);
			counter++;
			text.text = counter.ToString();
		}
	}

	public void OnCollisionEnter(Collision collider)
	{
		if (collider.gameObject.name == "EndPoint")
		{
			gameObject.SetActive (false);
		}
	}
}
