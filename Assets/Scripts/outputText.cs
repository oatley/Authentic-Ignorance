using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class outputText : MonoBehaviour {

	UnityEngine.UI.Text OutputText;
	public string[] OutputTextArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"};

	// Use this for initialization
	void Start () {
		OutputText = this.GetComponent<Text> ();
	}
	void Update() {

	}

}
