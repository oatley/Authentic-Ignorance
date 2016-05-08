using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine.UI;



public class cardGenerator : MonoBehaviour {

	List<string> good = new List<string>();
	List<string> bad = new List<string>();
	List<string> neutral = new List<string>();

	// Card values
	public int[] goodvalues = {-4,-3,1,2,3};
	public int[] badvalues = {-2,-1,3,4,4};
	public int[] neutralvalues = {-3,-2,2,3,3};

	// GUICARDS
	UnityEngine.UI.Text GUICard1;
	UnityEngine.UI.Text GUICard2;
	UnityEngine.UI.Text GUICard3;
	UnityEngine.UI.Text GUICard4;
	UnityEngine.UI.Text GUICard5;

	UnityEngine.UI.Text OutputText;

	UnityEngine.UI.Button GUICardDraw;

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

		playerDrawHand ();


	}

	public void playerDrawHand() {
		GUICard1 = GameObject.Find ("GUICard1Text").GetComponent<Text> ();
		GUICard1.text = generateCard ();
		GUICard2 = GameObject.Find ("GUICard2Text").GetComponent<Text> ();
		GUICard2.text = generateCard ();
		GUICard3 = GameObject.Find ("GUICard3Text").GetComponent<Text> ();
		GUICard3.text = generateCard ();
		GUICard4 = GameObject.Find ("GUICard4Text").GetComponent<Text> ();
		GUICard4.text = generateCard ();
		GUICard5 = GameObject.Find ("GUICard5Text").GetComponent<Text> ();
		GUICard5.text = generateCard ();
	}

	public string generateCard() {
		int cardalignment = new int();
		int cardscore = new int ();
		string entirecard;
		cardalignment = Random.Range (1, 4);
		cardscore = Random.Range (0, 4);


		if (cardalignment == 1) { // good
			string card = good [Random.Range (0, good.Count)]; // card name
			entirecard = card + "\ngood\n" + goodvalues [cardscore].ToString (); // string = name alignment score
		} else if (cardalignment == 2) { // bad
			string card = bad [Random.Range (0, bad.Count)]; // card name
			entirecard = card + "\nbad\n" + badvalues [cardscore].ToString (); // string = name alignment score
		} else if (cardalignment == 3) { // neutral
			string card = neutral [Random.Range (0, neutral.Count)]; // card name
			entirecard = card + "\nneutral\n" + neutralvalues [cardscore].ToString (); // string = name alignment score
		} else {
			entirecard = "meow good 20";
		}
		print (entirecard);
		return entirecard;

	}

	
	public void ClickRandomCard(){
		
	}
	
	public void ClickDrawCard(){
		GUICard1 = GameObject.Find ("GUICard1Text").GetComponent<Text> ();
		//GUICard1.text = generateCard ();
		GUICard2 = GameObject.Find ("GUICard2Text").GetComponent<Text> ();
		//GUICard2.text = generateCard ();
		GUICard3 = GameObject.Find ("GUICard3Text").GetComponent<Text> ();
		//GUICard3.text = generateCard ();
		GUICard4 = GameObject.Find ("GUICard4Text").GetComponent<Text> ();
		//GUICard4.text = generateCard ();
		GUICard5 = GameObject.Find ("GUICard5Text").GetComponent<Text> ();
		//GUICard5.text = generateCard ();
		if (GUICard1.text == "") {
			GUICard1.text = generateCard ();
		} else if (GUICard2.text == "") {
			GUICard2.text = generateCard ();
		} else if (GUICard3.text == "") {
			GUICard3.text = generateCard ();
		} else if (GUICard4.text == "") {
			GUICard4.text = generateCard ();
		} else if (GUICard5.text == "") {
			GUICard5.text = generateCard ();
		} 
		if (GUICard1.text != "" && GUICard2.text != "" && GUICard3.text != "" && GUICard4.text != "" && GUICard5.text != "") {
			GUICardDraw = GameObject.Find ("GUICardDraw").GetComponent<Button> ();
			GUICardDraw.interactable = false;
		}
	}












	// Update is called once per frame
	void Update () {
	
	}
}
