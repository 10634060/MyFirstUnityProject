using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Functions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void CurrentTime()
	{
		string greeting;
		int hour = DateTime.Now.Hour;

		if (hour < 12)
			greeting = "Good morning";
		else if (hour < 17)
			greeting = "Good afternoon";
		else
			greeting = "Good evening";

		print(string.Format ("{0}, the current time is {1}", greeting, DateTime.Now.ToLongTimeString()));
		//Greeting = {0}, TimeOfDay = {1}. You can use these more than once.
	}

	/*public void CurrentDate()
	{
		string greeting = "Hello";
		int date = DateTime.Now.DayOfYear;

		print (string.Format ("{0}, today is {1}.", greeting, date));
	}*/
}
