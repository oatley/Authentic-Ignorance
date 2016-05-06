using UnityEngine;
using System.Collections;

using UnityEngine.UI;



public class guiButton : MonoBehaviour {
	
	public void Click() {
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
}
