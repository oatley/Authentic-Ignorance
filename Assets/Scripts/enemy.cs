using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class enemy : MonoBehaviour {

	public List<string> enemyCard1;
	public List<string> enemyCard2;
	public List<string> enemyCard3;
	public List<string> enemyCard4;
	public List<string> enemyCard5;

	public GameObject cardGenerator;
	public GameObject runGameObject;

	// Use this for initialization
	void Start () {
		drawHand ();
	}

	void drawHand() {
		foreach (string s in Regex.Split (cardGenerator.GetComponent<cardGenerator> ().generateCard (), "\n")) {
			print("ENEMY: " + s);
			enemyCard1.Add(s);
		}
	}

}
