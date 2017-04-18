using UnityEngine;
using System.Collections;

public class ListsTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CountToTen ();
		print ("-----------");
		CountToTen ();
		print ("-----------");
		CountToTen ();
		print ("-----------");
		CountToTen ();
		print ("-----------");
	}

	void CountToTen () 
	{
		int i = 1;
		while (i < 10) 
		{
			print (i);
			i++;
		}
		print ("Congrats! You counted to 10!");
	}

}
