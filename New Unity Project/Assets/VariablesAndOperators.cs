using UnityEngine;
using System.Collections;

public class VariablesAndOperators : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 2.5f;

	private float length = 5f;
	private float width = 3.5f;

	private float triangleBase = 4f;
	private float triangleHeight = 4.5f;


	// Use this for initialization
	void Start () {
		//Find the diameter of a circle
		float diameter = 2 * radius;
		print ("The diameter of the circle with radius " + radius + " is " + diameter);

		//Find the area of a circle
		float area = pi * (radius * radius);
		print ("The area of a circle with radius " + radius + " is " + area);

		//Find the volume of a sphere
		float volume = (4/3) * pi * (radius * radius * radius);
		print ("The volume of a sphere with radius " + radius + " is " + volume);

		//Find perimeter of a rectangle
		float perimeter = 2 * (length + width);
		print ("The perimeter of a rectangle with length " + length + " and width " + width + " is " + perimeter);

		//Find area of a rectangle
		float rectangleArea = length * width;
		print ("The area of a rectangle with length " + length + " and width " + width + " is " + rectangleArea);

		//Find are of a triangle
		float triangleArea = (triangleBase * triangleHeight) / 2;
		print ("The area of a triangle with base " + triangleBase + " and height " + triangleHeight + " is " + triangleArea);
	}
}
