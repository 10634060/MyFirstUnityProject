using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {
	private float Gouda = 7.0f;
	private int Cheddar = 9;
	private bool Open = true;
	private string name = "Survey";

	// Use this for initialization
	void Start () {
		if (Open) 
		{
			print ("Welcome to Cheese World! We only serve two types of cheese. Sorry to disappoint you.");
		}
	
		if (!Open) 
		{
			print ("Welcome to Cheese World! We are currently closed. Sorry to disappoint you.");
		}

		if (name == "Survey") 
		{
			print ("What are your thoughts about cheese?");
		}
			
		if (name != "Survey") 
		{
			print ("We don't care about your cheesy thoughts.");	
		}

		if (name == "PepperJack") 
		{
			print ("I am Pepper Jack, and I am the best cheese of all.");
		}

		if (Gouda == Cheddar) 
		{
			print ("Cheddar is just as Gouda.");
		}
		if (Gouda != Cheddar) 
		{
			print ("Gouda and Cheddar are different. And that is okay.");
		}
		if (Gouda < Cheddar) 
		{
			print ("Cheddar is better than Gouda.");
		}
		if (Gouda > Cheddar) 
		{
			print ("Gouda is better than Cheddar.");
		}
		if (Gouda <= Cheddar) 
		{
			print ("Gouda and Cheddar are both okay, I guess.");
		}
		if (Gouda >= Cheddar)
		{
			print ("I don't have a preference between Gouda and Cheddar.");
		}

	}
}
