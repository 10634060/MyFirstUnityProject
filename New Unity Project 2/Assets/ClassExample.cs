
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClassExample : MonoBehaviour {
	float[] scores = {98f, 78f, 88f, 94f};

	// Use this for initialization
	void Start () {
		print(Average (scores));

	}
	
	float Add (float num1, float num2)
	{
		float sum;
		sum = num1 + num2;
		return sum;
	}

	float Average (float[] scores)
	{
		float sum = 0;

		foreach (float thisScore in scores) 
		{
			sum += thisScore;
			//+= means sum = sum + thisScore;
		}

		mean = sum / scores.Length;
		return mean;
	}
}
