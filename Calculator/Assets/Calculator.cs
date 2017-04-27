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
	private Vector3 startPos;





	void Start () 
	{

		clearInputs ();

		//Target Number
		startPos = transform.position;
		randNum = UnityEngine.Random.Range (0, 101);
		targetNum.text = randNum.ToString ();

		buttonReset ();


	}


	void Update ()
	{

		if (result.text == targetNum.text) 
		{
			GetComponent<Rigidbody> ().position = startPos;
			result.color = Color.green;

			Reset ();

		}
						

	}



	public void Add()
	{

		int sum;
		sum = System.Int32.Parse(field1.text) + System.Int32.Parse(field2.text);
		result.text = sum.ToString();


		if (result.text == targetNum.text) 
		{
			gameObject.SetActive (false);
		} 
		else 
		{
				gameObject.SetActive (true);
				result.color = Color.red;
		}

		clearInputs ();


	}

	public void Sub()
	{
		int diff;
		diff = System.Int32.Parse(field1.text) - System.Int32.Parse(field2.text);
		result.text = diff.ToString();


		if (result.text == targetNum.text) 
		{
			gameObject.SetActive (false);
		} 
		else 
		{
			gameObject.SetActive (true);
			result.color = Color.red;
		}

		clearInputs ();
	}

	public void Mult()
	{
		int product;
		product = System.Int32.Parse(field1.text) * System.Int32.Parse(field2.text);
		result.text = product.ToString();



		if (result.text == targetNum.text) 
		{
			gameObject.SetActive (false);
		} 
		else 
		{
			gameObject.SetActive (true);
			result.color = Color.red;
		}

		clearInputs ();

	}

	public void Div()
	{
		int quotient;
		quotient = System.Int32.Parse(field1.text) / System.Int32.Parse(field2.text);
		result.text = quotient.ToString();


		if (result.text == targetNum.text) 
		{
			gameObject.SetActive (false);
		} 
		else 
		{
			gameObject.SetActive (true);
			result.color = Color.red;
		}

		clearInputs ();

	}

	public void clearInputs()
	{
		field1.text = String.Empty;
		field2.text = String.Empty;

	}

	public void buttonReset ()
	{	
		gameObject.SetActive (true);
	}


	void Reset ()
	{
		Vector3 startPos = new Vector3(0,275,0);

		randNum = UnityEngine.Random.Range (0, 101);
		targetNum.text = randNum.ToString ();

	}
		
}

