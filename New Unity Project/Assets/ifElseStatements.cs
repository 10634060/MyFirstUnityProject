using UnityEngine;
using System.Collections;

public class ifElseStatements : MonoBehaviour {
	/* To demonstrate if/else statements, I am using the example 
	 of a heart rate tracking app */

	// This is the message that will show up when the app is turned on or off.
	private bool power = true;

	// "bpm" stands for beats per minute.
	private float bpm;
	
	// Use this for initialization
	void Start () {
		// The app will greet the user when it is powered on.
		if (power) 
		{
			print ("Hi! I'm your new heart rate tracking buddy!");
		} 
		// The app will greet the user when it is powered off.
		else 
		{
			print ("See you next time!");
		}


		/* The average adult resting heart rate ranges between 60 - 100 bpm.
		For this example, I will be using 100 as the maximum. Keep in mind, 
		higher heart rates are not good. Therefore, anything above 100 bpm
		should cause the app to warn the user of a high heart rate. */

		if (bpm > 100) 
		{
			print ("Calm down!");
		} 
		// 60 - 100 bpm is a good thing. Anything above 60 bpm will praise the user.
		else if (bpm > 60) 
		{
			print ("Good job!");
		}
			
		/* Healthier people (such as athletes) may have a heart rate less than 60 bpm.
		in this case, if the user's heart rate reaches 40, they will be praised. */
		else if (bpm > 40) 
		{
			print ("Excellent work!");
		} 

		/* Although lower heart rates can be good, too low of a heart rate can be bad.
		When the user's heart rate is 10 bpm, the app will check on the user. */
		else if (bpm > 10) 
		{
			print ("Hey! Are you still alive?");
		}


	
	}

}
