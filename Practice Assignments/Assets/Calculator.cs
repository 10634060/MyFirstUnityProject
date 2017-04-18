using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Calculator : MonoBehaviour {

	private int randomNum = 10;

	string[] name = { "Bob", "Sean", "Taryn", "Marshall", "Rebecca" };
	string[] color = {"Blue", "Orange", "Green", "Purple", "Maroon"};



	// Use this for initialization
	void Start () {

		Mult (3f, 5f, 7f);
		//These will be substituted into x, y, and z in the Mult function



		for (int i = 0; i < name.Length; i++) 
		{
			print ("name[4] loves the color[4].");
		}


	}
	
	public void Mult(float x, float y, float z)
	{

		var result = x * y * z;
		print (string.Format("The product of these numbers is {0}.", result));
	}



}
