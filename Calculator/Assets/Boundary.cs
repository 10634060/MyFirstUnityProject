using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter (Collider targetNum)
	{
		print (targetNum);
		Destroy (targetNum.gameObject);
	
	}
	

}
