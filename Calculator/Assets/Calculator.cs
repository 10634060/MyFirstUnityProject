using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;




public class Calculator : MonoBehaviour {

	public InputField field1;
	public InputField field2;
	public Text result;


	//Target Number
	int randNum;
	public Text targetNum;


	void Start () 
	{

		clearInputs ();

		//Target Number
		randNum = UnityEngine.Random.Range (0, 101);
		targetNum.text = randNum.ToString ();

	}

	void Update ()
	{

	}
		

	public void Add()
	{
		int sum;
		sum = System.Int32.Parse(field1.text) + System.Int32.Parse(field2.text);
		result.text = sum.ToString();
	
	}

	public void Sub()
	{
		int diff;
		diff = System.Int32.Parse(field1.text) - System.Int32.Parse(field2.text);
		result.text = diff.ToString();

	}

	public void Mult()
	{
		int product;
		product = System.Int32.Parse(field1.text) * System.Int32.Parse(field2.text);
		result.text = product.ToString();

	}

	public void Div()
	{
		int quotient;
		quotient = System.Int32.Parse(field1.text) / System.Int32.Parse(field2.text);
		result.text = quotient.ToString();

	}

	public void clearInputs()
	{
		field1.text = String.Empty;
		field2.text = String.Empty;
	}

	


}
