using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine.UI;


// Should be renamed to cardController or something
public class cardGenerator : MonoBehaviour {

	List<string> good = new List<string>();
	List<string> bad = new List<string>();
	List<string> neutral = new List<string>();

	// Card values
	public int[] goodvalues = {-4,-3,1,2,3};
	public int[] badvalues = {-2,-1,3,4,4};
	public int[] neutralvalues = {-3,-2,2,3,3};

	// GUICARDS text
	UnityEngine.UI.Text GUICard1;
	UnityEngine.UI.Text GUICard2;
	UnityEngine.UI.Text GUICard3;
	UnityEngine.UI.Text GUICard4;
	UnityEngine.UI.Text GUICard5;

	// GUICARDS buttons
	UnityEngine.UI.Button GUICard1Button;
	UnityEngine.UI.Button GUICard2Button;
	UnityEngine.UI.Button GUICard3Button;
	UnityEngine.UI.Button GUICard4Button;
	UnityEngine.UI.Button GUICard5Button;


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

	public void playerDiscardHand() {
		GUICard1 = GameObject.Find ("GUICard1Text").GetComponent<Text> ();
		GUICard2 = GameObject.Find ("GUICard2Text").GetComponent<Text> ();
		GUICard3 = GameObject.Find ("GUICard3Text").GetComponent<Text> ();
		GUICard4 = GameObject.Find ("GUICard4Text").GetComponent<Text> ();
		GUICard5 = GameObject.Find ("GUICard5Text").GetComponent<Text> ();
		GUICard1Button = GameObject.Find ("GUICard1").GetComponent<Button> ();
		GUICard2Button = GameObject.Find ("GUICard2").GetComponent<Button> ();
		GUICard3Button = GameObject.Find ("GUICard3").GetComponent<Button> ();
		GUICard4Button = GameObject.Find ("GUICard4").GetComponent<Button> ();
		GUICard5Button = GameObject.Find ("GUICard5").GetComponent<Button> ();
		GUICard1Button.interactable = false;
		GUICard1.text = "";
		GUICard2Button.interactable = false;
		GUICard2.text = "";
		GUICard3Button.interactable = false;
		GUICard3.text = "";
		GUICard4Button.interactable = false;
		GUICard4.text = "";
		GUICard5Button.interactable = false;
		GUICard5.text = "";

		// Enable draw card button
		GUICardDraw = GameObject.Find ("GUICardDraw").GetComponent<Button> ();
		GUICardDraw.interactable = true;
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

//		print (neutral.Count.ToString()); //DEBUG CODE
//		print (bad.Count.ToString());
//		print (good.Count.ToString());
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
			entirecard = "meow\ngood\n20";
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
		GUICard1Button = GameObject.Find ("GUICard1").GetComponent<Button> ();
		//GUICard1.text = generateCard ();
		GUICard2Button = GameObject.Find ("GUICard2").GetComponent<Button> ();
		//GUICard2.text = generateCard ();
		GUICard3Button = GameObject.Find ("GUICard3").GetComponent<Button> ();
		//GUICard3.text = generateCard ();
		GUICard4Button = GameObject.Find ("GUICard4").GetComponent<Button> ();
		//GUICard4.text = generateCard ();
		GUICard5Button = GameObject.Find ("GUICard5").GetComponent<Button> ();
		//GUICard5.text = generateCard ();
		if (GUICard1.text == "") {
			GUICard1Button.interactable = true;
			GUICard1.text = generateCard ();

		} else if (GUICard2.text == "") {
			GUICard2Button.interactable = true;
			GUICard2.text = generateCard ();

		} else if (GUICard3.text == "") {
			GUICard3Button.interactable = true;
			GUICard3.text = generateCard ();

		} else if (GUICard4.text == "") {
			GUICard4Button.interactable = true;
			GUICard4.text = generateCard ();

		} else if (GUICard5.text == "") {
			GUICard5Button.interactable = true;
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
