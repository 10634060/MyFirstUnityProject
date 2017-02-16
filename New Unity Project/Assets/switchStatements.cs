using UnityEngine;
using System.Collections;

public class switchStatements : MonoBehaviour {

	/* The idea for my example is an app that will teach people about rock band instruments. */
	private string instrument = "oboe";
	private string phrase;
	private bool rock = true;


	// Use this for initialization
	void Start () {
		// Each case is a rock band instrument. A phrase will give the user information about the instrument.
		switch (instrument) 
		{
			case "guitar":
				phrase = "a string instrument with 6 strings. It can be electric or acoustic";
				break;
			case "bass":
				phrase = "a string instrument with 4 strings. It can be electric or acoustic";
				break;
			case "drum":
				phrase = "a percussion instrument. Drumsticks are optional";
				break;
			case "singer":
				phrase = "optional. They may or may not be divas";
				break;
			case "keyboard":
				phrase = "a percussion instrument. It is like a piano and it can be electric or acoustic";
				break;
			// If the user enters an instrument that is not a rock band instrument, then they will be directed to the "else" statement.
			default:
				rock = false;
				break;
		}

		// If the user enters a rock band instrument, then the assigned phrase will be displayed.
		if (rock == true)
		{ 
			print ("The " + instrument + " is " + phrase + ".");
		}
		// If the user enters an instrument that is not considered a rock instrument, then this alternate phrase will be displayed.
		else
		{ 
			print ("The " + instrument + " is not a rock band instrument, silly goose!");
		}

	}

}
