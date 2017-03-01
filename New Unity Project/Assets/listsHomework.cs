using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listsHomework : MonoBehaviour {
	public string animal;
	public List<string> zooRoster = new List<string>();

	private int counter = 0;

	// Use this for initialization
	void Start () {
		zooRoster.Add ("monkey");
		zooRoster.Add ("elephant");
		zooRoster.Add ("alligator");
	}

	public void AddAnimal()
	{
		if (animal != "") 
		{
			if (zooRoster.Contains (animal) != true)
			{
				zooRoster.Add (animal);
			}
		}
	}

	public void RemoveAnimal()
	{
		if (animal != "") 
		{
			if (zooRoster.Contains (animal) == true) 
			{
				zooRoster.Remove (animal);
			}
		}
	}

	public void ClearAnimal()
	{
		if (animal == "") 
		{
			if (zooRoster.Contains (animal) != true) 
			{
				zooRoster.Clear();
			}
		}
	}

	public void PrintAnimal()
	{
		if(animal == "")
		{	
			if(zooRoster.Contains (animal) != true)
			{ 
				foreach (string animal in zooRoster)
				{
					print (animal);
				}
			}
		}		
	}



}
