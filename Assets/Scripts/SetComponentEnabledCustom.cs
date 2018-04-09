using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetComponentEnabledCustom : MonoBehaviour
{
	private MoveBehaviour move;
	private BasicBehaviour basic;

	// Use this for initialization
	void Start ()
	{

		basic = GetComponent<BasicBehaviour>();
		move = GetComponent<MoveBehaviour>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void disableComponents()
	{
		basic.enabled = false;
		move.enabled = false;
	}

	public void enableComponents()
	{
		basic.enabled = true;
		move.enabled = true;
	}
}
