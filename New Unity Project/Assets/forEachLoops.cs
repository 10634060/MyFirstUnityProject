/* using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class forEachLoops : MonoBehaviour {

	public List<string> animals = new List<string>();
	public List<string> cats;
	public List<string> dogs;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < animals.Count; i++) {

			switch (animals[i]) 
			{
			case "cat":
				cats.Add (animals[i]);
				break;

			case "dog":
				dogs.Add(animals[i]);
				break;
			}
			
		}

		foreach (string animal in animals) {
			print (animal);

			switch (animal) 
			{
			case "cat":
				cats.Add (animal);
				break;

			case "dog":
				dogs.Add(animal);
				break;
			}

		
		}
	
	}
} */
