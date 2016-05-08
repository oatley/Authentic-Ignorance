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

	List<List<string>> enemyHand = new List<List<string>>();

	public GameObject cardGenerator;
	public GameObject runGameObject;
	public GameObject outputText;

	// Use this for initialization
	void Start () {
		drawHand ();
	}

	public void playCard() {
		int enemyscore = runGameObject.GetComponent<runGame> ().enemyscore;
		int goalscore = runGameObject.GetComponent<runGame> ().goalscore;
		int difference = goalscore - enemyscore;
		if (enemyscore > goalscore) { // USE A NEGATIVE CARD
			foreach (List<string> card in enemyHand) {
//				if(difference == card[2]) { // play this card
//					print("ENEMY WINS");
//				} else if (( ) // 10 - 7 = 3
			}
		} else if (goalscore > enemyscore) { // USE POSITIVE CARD
			foreach (List<string> card in enemyHand) {


			}
		} else { // ENEMY WINS

		}

		// Play random card
		int randCard = Random.Range (0, 5);
		if (enemyHand [randCard] [0].ToString () == "") { // No card here, please draw a card
			// New Card
			string[] temp = Regex.Split (cardGenerator.GetComponent<cardGenerator> ().generateCard (), "\n");
			enemyHand [randCard] [0] = temp [0];
			enemyHand [randCard] [1] = temp [1];
			enemyHand [randCard] [2] = temp [2];
			outputText.GetComponent<Text>().text = outputText.GetComponent<Text>().text + "Enemy - Draw Card";
		} else {
			print ("Playing card");
			if (enemyHand[randCard][1] == "bad") {
				runGameObject.GetComponent<runGame>().terribleThings.Add(enemyHand[randCard][0]);
				GameObject.Find ("runGameObject").GetComponent<runGame>().UpdateAIText(enemyHand[randCard][0]);
			}
			outputText.GetComponent<Text>().text = outputText.GetComponent<Text>().text + "Enemy - " + enemyHand [randCard] [0].ToString() +","+ enemyHand [randCard] [1].ToString() +","+ enemyHand [randCard] [2].ToString();
			runGameObject.GetComponent<runGame>().ChangeEnemyScore(int.Parse(enemyHand[randCard][2]));
			enemyHand[randCard][0] = "";
			enemyHand[randCard][1] = "";
			enemyHand[randCard][2] = "";
		}
		// Split the value of the TextOutput and store in array
		string[] OutputTextArray = Regex.Split(outputText.GetComponent<Text>().text, "\n");
		
		// Delete old value
		outputText.GetComponent<Text>().text = "";
		
		if (OutputTextArray.Length > 10) {
			print (OutputTextArray.Length);
			// Shift array so it looks like it's scrolling up
			for (int i = 1; i < OutputTextArray.Length; i++) {
				OutputTextArray [i - 1] = OutputTextArray [i];
				outputText.GetComponent<Text>().text = outputText.GetComponent<Text>().text + OutputTextArray [i] + "\n";
			}
		} else {
			print (OutputTextArray.Length);
			for (int i = 0; i < OutputTextArray.Length; i++) {
				outputText.GetComponent<Text>().text = outputText.GetComponent<Text>().text + OutputTextArray [i] + "\n";
			}
		}
		//}
	}

	void drawHand() {
		foreach (string s in Regex.Split (cardGenerator.GetComponent<cardGenerator> ().generateCard (), "\n")) {
			enemyCard1.Add(s);
		}
		foreach (string s in Regex.Split (cardGenerator.GetComponent<cardGenerator> ().generateCard (), "\n")) {
			enemyCard2.Add(s);
		}
		foreach (string s in Regex.Split (cardGenerator.GetComponent<cardGenerator> ().generateCard (), "\n")) {
			enemyCard3.Add(s);
		}
		foreach (string s in Regex.Split (cardGenerator.GetComponent<cardGenerator> ().generateCard (), "\n")) {
			enemyCard4.Add(s);
		}
		foreach (string s in Regex.Split (cardGenerator.GetComponent<cardGenerator> ().generateCard (), "\n")) {
			enemyCard5.Add(s);
		}
		enemyHand.Add (enemyCard1);
		enemyHand.Add (enemyCard2);
		enemyHand.Add (enemyCard3);
		enemyHand.Add (enemyCard4);
		enemyHand.Add (enemyCard5);
		//playCard ();
	}

}
