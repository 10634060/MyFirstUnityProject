using UnityEngine;
using System.Collections;

public class arraysHomework : MonoBehaviour {

	//Remember, strings are for names, ints are for numbers

	private string[] camp = { "band", "boot", "summer" };
	private string[] person1 = { "Alyssa", "Kyle", "Emerson", "Erin" };
	private string[] person2 = { "Sadie", "Travis", "Karma", "Gabe" };
	private string[] noun1 = { "wood", "rocks", "duct tape", "bricks", "mud" };
	private string[] structure = { "fire", "cabin", "bridge", "treehouse" };
	private string[] emotion = { "funny", "happy", "strange", "angry", "sad", "excited" };
	private string[] verb = { "sat", "cried", "laughed", "stared", "pondered" };
	private string[] pluralFood = { "cookies", "brownies", "berries", "sushi rolls", "steaks" };
	private string[] pastVerb = { "laughed", "cried", "sighed", "shrugged" };
	private int[] number = { 3,5,7,9,12 };
	private string[] pastVerb2 = { "burped", "coughed", "gagged", "grimaced" };


	bool storyTime = true


	// Use this for initialization
	void Start () {
		// Example: adj1[Random.Range(0,adj1.Length)]

		string camp = Random.Range (0, camp.Length);
	
		print ("This one time, at" + camp + " camp, ");


	
		/* Story: This one time, at [camp] camp, [person1] and [person2] were looking for [noun1] to build a [structure]. Along the way, 
		they began to feel very [emotion]. They [verb] for a while. Finally, [person2] said, "Hey, do you think there was something 
		in those [pluralFood] that we ate"?. [person1] [pastVerb] and said "I don't know! But I ate [number]!" The two [pastVerb2]
		and continued looking for [noun1]. The End. */
			
	}

}
