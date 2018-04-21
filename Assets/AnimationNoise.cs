using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationNoise : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Animator anim = GetComponent<Animator>();
		int state = Random.Range(0, 2);
		if(state == 0)
			anim.Play("attack2", -1, Random.Range(0f, 1f));
		else
			anim.Play("attack1", -1, Random.Range(0f, 1f));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
