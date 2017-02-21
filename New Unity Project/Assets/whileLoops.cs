using UnityEngine;
using System.Collections;

public class whileLoops : MonoBehaviour {
	public int bottles = 0;
	public int maxBottles = 10;

	private bool gameOn = true;

	private int minVal = -10;
	private int maxVal = 10;
	private int randomNum;
	private int counter = 0;

	// Use this for initialization
	void Start () {

		while (true)
		{
			randomNum = Random.Range(minVal, maxVal);
			if (randomNum > 0)
			{
				maxVal = randomNum;
			} 
			else if (randomNum < 0) 
			{
				minVal = randomNum;
			}

			counter++;
			print ("Attempt " + counter + ": " + minVal + " - " + maxVal);

			if (maxVal == 1 && minVal == -1) 
			{
				break;
			}
		}







//		while (gameOn == true) 
//		{
//			print (bottles + " bottles of root beer on the wall.");
//			bottles++;
//			if (bottles == maxBottles)
//			{
//				break;
//			}
//		}





//		while(bottles < 20)
//		{ 
//			print(bottles + " bottles of root beer on the wall.");
//			bottles = bottles + 2;
//		}
//		print ("All done!");
//	
	}

}
