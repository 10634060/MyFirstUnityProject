using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class fallingNumber : MonoBehaviour {


	public float fallSpeed = 5.0f;
	public Text result;

	public Text targetNum;

	void Start () 
	{
		
	}

	void Update () 
	{
		while (result.text != targetNum.text) 
		{
			transform.Translate (Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		}

	}

	/*public void Destroy()
	{
		if (result.text == targetNum.text) {
			Destroy (targetNum);
		} 
		else 
		{
			print ("You Fail.");
		}
	}*/
}
