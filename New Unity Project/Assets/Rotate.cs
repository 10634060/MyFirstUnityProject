using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float speed;

	/* These are variables assigned to the speed of the cubes' rotation. We must declare them before using them in the code.
	Rather than writing individual number values throughout the code, we can use variables instead. 
	Making these variables public allows us to edit them in Unity. */
	public float rotX = 15;
	public float rotY = 30;
	public float rotZ = 45;

	// Use this for initialization
	void Start () {
		speed = Random.Range (.5f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//The variables can be found here in place of numeric values//
		transform.Rotate (new Vector3 (rotX, rotY, rotZ) * Time.deltaTime * speed);
	}
}
