using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class fallingNumber : MonoBehaviour {

	int randNum;
	public Text targetNum;
	public Vector3 spawn = new Vector3(0, 274, 0);



	void Start () 
	{

		GameObject targetSpawn = (GameObject)Instantiate(targetNum, new Vector3(0,2,0), transform.rotation);
		randNum = UnityEngine.Random.Range (0, 101);
		targetNum.text = randNum.ToString ();
	}



		
}
