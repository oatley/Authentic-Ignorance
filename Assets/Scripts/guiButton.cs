using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class guiButton : MonoBehaviour {

	public void Click() {
		print ("MEOOOOW");
		if (this.GetComponent<Text> ().text == "Exit") {
			print (this.GetComponent<Text> ().text);
		}

	}
}
