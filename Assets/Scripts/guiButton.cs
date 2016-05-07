using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class guiButton : MonoBehaviour {

	UnityEngine.UI.Text OutputText;
	//public string[] OutputTextArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"};

	public void ClickMenu() {
		print ("MEOOOOW");
		print (this.GetComponentInChildren<Text> ().text);
		if (this.GetComponentInChildren<Text> ().text == "Exit") {
			print(this.GetComponentInChildren<Text> ().text);
			Application.Quit ();
		} else if (this.GetComponentInChildren<Text> ().text == "Menu") {
			print("THIS NOT WORKING");
			Application.LoadLevel("Main");
		}
	}
	public void ClickCard(){
		print ("I want the money, give me the money");
		OutputText = GameObject.Find("OutputText").GetComponent<Text>();

		// Add new value to output text
		OutputText.text = OutputText.text + this.GetComponentInChildren<Text> ().text;
		// Split the value of the TextOutput and store in array
		string[] OutputTextArray = Regex.Split(OutputText.text, "\n");
		// Delete old value
		OutputText.text = "";
		// Shift array so it looks like it's scrolling up
		for (int i = 1; i < 13; i++) {
			OutputTextArray[i - 1] = OutputTextArray[i];
			OutputText.text = OutputText.text + OutputTextArray [i] + "\n" ;
		}

		// Set new value
//		OutputTextArray [12] = "Meow";

		// Set text screen output
//		OutputText.text = OutputTextArray[0] + "\n";
//		for (int i = 1; i < 13; i++) {
//			OutputText.text = OutputText.text + OutputTextArray [i] + "\n" ;
//		}
	}

}
