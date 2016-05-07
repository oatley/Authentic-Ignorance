using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;


public class cardGenerator : MonoBehaviour {

	List<string> good = new List<string>();
	List<string> bad = new List<string>();
	List<string> neutral = new List<string>();
	
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

	void generateCard() {
		int alignment = Random.Range (1, 3);
		int some1 = Random.Range (1, 3);
		int dude = Random.Range (1, 3);
	}



	// Update is called once per frame
	void Update () {
	
	}
}
