using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Collections.Generic;

public class Calculator : MonoBehaviour {

	public InputField input1;
	public InputField input2;
	public Text result;



	void Start () {

		AddNumbers ();
	

	}

	public void AddNumbers()
	{
		int numInput;

		numInput = int.Parse(input1.text) + int.Parse(input2.text);

		result.text = numInput.ToString();
		
	}
	


}
