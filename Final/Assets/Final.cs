using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Final : MonoBehaviour {

	private bool awake = true;
	string name = "Alyssa";
	int hour = DateTime.Now.Hour;

	float[] numbers = {38f, 90f, 27f, 56f};

	double feet = 1;
	double inch = 12;

	// Use this for initialization
	void Start () {

	//Exercise 1
		while (awake) 
		{
			print ("Hello, " + "my name is " + name + " and it is currently " + DateTime.Now.ToLongTimeString () + ".");
			break;
		}
			
		print ("The average is " + Average (numbers) + ".");
		print (FeetToInches ());
	
	}

	//Exercise 2
	public float Math (float num1, float num2)
	{
		float sum;
		sum = num1 + num2;
		return sum;
		print (sum);

		float diff;
		diff = num1 - num2;
		return diff;
		print (diff);

		float prod;
		prod = num1 * num2;
		return prod;
		print (prod);

		float quot;
		quot = num1 / num2;
		return quot;
		print (quot);
	}

	//Exercise 3
	public float Average(float[] numbers)
	{
		float sum = 0;

			foreach (float number in numbers)
			{	
			sum += number;
			}
			
		float ave = sum / numbers.Length;
		return ave;

	}

	//Exercise 4
	public int FeetToInches ()
	{
		double ft = 3;
		double result;

		result = (ft * feet) / inch;
		return Convert.ToInt32(result);

	}	

	//Exercise 5
	public int Trains (int trainA, int trainB, int hours)
	{
		int cityA = 0;
		int distance = ((cityA + trainA) + (cityA + trainB)) * hours;
		return distance;
	}
}
