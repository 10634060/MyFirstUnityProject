using UnityEngine;
using System.Collections;

public class whileLoops : MonoBehaviour {


// I want the computer to guess the number 25.

	private bool gameOn = true;

	private int minVal = -10;
	private int maxVal = 100;
	//The randomNum is assigned to 25
	private int randomNum = 25;
	private int counter = 0;

	// Use this for initialization
	void Start () {

		while (true)
		{
			randomNum = Random.Range(minVal, maxVal);
			if (randomNum > 25)
			{
				maxVal = randomNum;
			} 
			else if (randomNum < 25) 
			{
				minVal = randomNum;
			}

			counter++;
			print ("Guess " + counter + ": " + minVal + " - " + maxVal);

			/* 25 is between 24 and 26. If the computer guesses this range,
			then the loop will break. */
			if (maxVal == 26 && minVal == 24) 
			{
				break;
			}
		}

	}

}
