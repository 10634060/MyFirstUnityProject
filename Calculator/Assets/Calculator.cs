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

		clearInputs ();
	}


	/*public int num1;
	public int num2;

	public void Hello(string name)
	{
		print ("Hello " + name + ", you're looking marvelous today.");
		int result = num1 + num2;
		print(string.Format("{0} + {1} = {2}", num1, num2, result));

	}*/

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
