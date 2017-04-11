using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;



public class Calculator : MonoBehaviour {

	public InputField field1;
	public InputField field2;
	public Text result;




	void Start () {

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



}
