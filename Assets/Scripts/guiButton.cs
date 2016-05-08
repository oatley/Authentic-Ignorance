using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class guiButton : MonoBehaviour {

	UnityEngine.UI.Text OutputText;

	public void ClickMenu() {
		OutputText = GameObject.Find("OutputText").GetComponent<Text>();

		// Print the button text in console
		print (this.GetComponentInChildren<Text> ().text);

		// Check text what button was pressed and decide what to do
		if (this.GetComponentInChildren<Text> ().text == "Exit") {
			Application.Quit ();
		} else if (this.GetComponentInChildren<Text> ().text == "Menu") {
			Application.LoadLevel ("Main");
		} else if (this.GetComponentInChildren<Text> ().text == "Meow") {
			OutputText.text = "MEEEEOOOOOOOOOOW\n";
		}
	}

	public void discardCard() {
		this.GetComponentInChildren<Text> ().text = "";
	}

	public void ClickCard(){

		print ("I want the money, give me the money");
		OutputText = GameObject.Find ("OutputText").GetComponent<Text> ();

		if (this.GetComponentInChildren<Text> ().text == "") {
			OutputText.text = OutputText.text + "please draw a new card";
		} else {
			// Add new value to output text
			OutputText.text = OutputText.text + this.GetComponentInChildren<Text> ().text.Replace ("\n", ",");
		}
		// Split the value of the TextOutput and store in array
		string[] OutputTextArray = Regex.Split(OutputText.text, "\n");

		// Delete old value
		OutputText.text = "";

		if (OutputTextArray.Length > 11) {
			print (OutputTextArray.Length);
			// Shift array so it looks like it's scrolling up
			for (int i = 1; i < OutputTextArray.Length; i++) {
				OutputTextArray [i - 1] = OutputTextArray [i];
				OutputText.text = OutputText.text + OutputTextArray [i] + "\n";
			}
		} else {
			print (OutputTextArray.Length);
			for (int i = 0; i < OutputTextArray.Length; i++) {
				OutputText.text = OutputText.text + OutputTextArray [i] + "\n";
			}
		}

		// Discard the card you used
		discardCard ();


	}
}




