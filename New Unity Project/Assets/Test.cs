using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
	public int minRange = 0;
	public int maxRange = 100;
	public int target = 42;
	private int counter = 0;

	// Use this for initialization
	void Start ()
	{
		int counter = 0;

		while (true) 
		{
			int guess = Random.Range (minRange, maxRange);
			counter++;

			if (guess == target)
			{
				print ("Attempt " + counter + ": You guessed the correct number, " + target + ".");
				break;
			}
			else if (guess < target) 
			{
				print("Attempt " + counter + ": " + guess + " is too low.");
				minRange = guess;
			}
			else
			{
				print("Attempt " + counter + ": " + guess + " is too high.");
				maxRange = guess;
			}
		}
		print ("You win!");


	}
}

