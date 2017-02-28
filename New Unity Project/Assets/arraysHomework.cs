using UnityEngine;
using System.Collections;

public class arraysHomework : MonoBehaviour {

	private int randomNum = 11;

	string[] camp = { "band", "boot", "summer" };
	/*string[] person1 = { "Alyssa", "Kyle", "Emerson", "Erin" };
	string[] person2 = { "Sadie", "Travis", "Karma", "Gabe" };
	string[] noun1 = { "wood", "rocks", "duct tape", "bricks", "mud" };
	string[] structure = { "fire", "cabin", "bridge", "treehouse" };
	string[] emotion = { "funny", "happy", "strange", "angry", "sad", "excited" };
	string[] verb = { "sat", "cried", "laughed", "stared", "pondered" };
	string[] pluralFood = { "cookies", "brownies", "berries", "sushi rolls", "steaks" };
	string[] pastVerb = { "laughed", "cried", "sighed", "shrugged" };
	int[] number = { 3,5,7,9,12 };
	string[] pastVerb2 = { "burped", "coughed", "gagged", "grimaced" }; */




		// Use this for initialization
		void Start () {

		// Example: adj1[Random.Range(0,adj1.Length)]

		while(true)
		{
			camp [Random.Range (0, camp.Length)];
			if (randomNum > 10) 
			{
				print ("This one time, at " + camp + "camp...");
				/*person1[Random.Range (0, person1.Length)];
				person2[Random.Range (0, person2.Length)];
				noun1[Random.Range (0, noun1.Length)];
				structure[Random.Range (0, structure.Length)];
				emotion[Random.Range (0, emotion.Length)];
				verb[Random.Range (0, verb.Length)];
				pluralFood[Random.Range (0, pluralFood.Length)];
				pastVerb[Random.Range (0, pastVerb.Length)];
				number[Random.Range (0, number.Length)];
				pastVerb2[Random.Range (0, pastVerb2.Length)];*/

			} 
			else if (randomNum < 10) 
			{
				print("Enter 11 to read a story");
			}
			if (randomNum == 10) 
			{
				break;
			}	


		}
	}
}

/* Story: This one time, at [camp] camp, [person1] and [person2] were looking for [noun1] to build a [structure]. Along the way, 
they began to feel very [emotion]. They [verb] for a while. Finally, [person2] said, "Hey, do you think there was something 
in those [pluralFood] that we ate"?. [person1] [pastVerb] and said "I don't know! But I ate [number]!" The two [pastVerb2]
and continued looking for [noun1]. The End. */