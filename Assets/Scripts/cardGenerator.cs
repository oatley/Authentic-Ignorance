using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;


public class cardGenerator : MonoBehaviour {

	List<string> good = new List<string>();
	List<string> bad = new List<string>();
	List<string> neutral = new List<string>();

	// Card values
	public int[] goodvalues = {-4,-3,1,2,3};
	public int[] badvalues = {-2,-1,3,4,4};
	public int[] neutralvalues = {-3,-2,2,3,3};


	
	// Use this for initialization
	void Start () {

		StreamReader input_stream = new StreamReader("Assets/Text/goodwords.txt");
		while(!input_stream.EndOfStream)
		{
			string line = input_stream.ReadLine( );
			good.Add (line);
		}
		input_stream.Close( );
		input_stream = new StreamReader("Assets/Text/badwords.txt");
		while(!input_stream.EndOfStream)
		{
			string line = input_stream.ReadLine( );
			bad.Add (line);
		}
		input_stream.Close( );
		input_stream = new StreamReader("Assets/Text/neutralwords.txt");
		while(!input_stream.EndOfStream)
		{
			string line = input_stream.ReadLine( );
			neutral.Add(line);
		}
		input_stream.Close( );
	}

	public void generateCard() {
		int cardalignment = new int();
		int cardscore = new int ();
		cardalignment = Random.Range (1, 4);
		cardscore = Random.Range (0, 4);


		if (cardalignment == 1) { // good
			string card = good [Random.Range (0, good.Count)]; // card name
			print (card + " good " + goodvalues [cardscore].ToString ()); // string = name alignment score
		} else if (cardalignment == 2) { // bad
			string card = bad [Random.Range (0, bad.Count)]; // card name
			print (card + " bad " + badvalues [cardscore].ToString ()); // string = name alignment score
		} else if (cardalignment == 3) { // neutral
			string card = neutral [Random.Range (0, neutral.Count)]; // card name
			print (card + " neutral " + neutralvalues [cardscore].ToString ()); // string = name alignment score
		} else {
			print("meow good 20");
		}

	}



	// Update is called once per frame
	void Update () {
	
	}
}
