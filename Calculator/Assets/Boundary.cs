using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Boundary : MonoBehaviour {

	public Text loseText;


	// Use this for initialization
	void Start () {

		loseText.text = "";

	}

	void OnTriggerEnter (Collider targetNum)
	{
		
		Destroy(targetNum.gameObject);
		LoseText ();

	}

	void LoseText ()
	{
		loseText.text = "You Lose!";
	}


}
