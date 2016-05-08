using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// Probably should be called point controller or something
public class runGame : MonoBehaviour {

	public List<string> terribleThings;

	public int playerscore = new int();
	public int enemyscore = new int();
	public int goalscore = new int();

	public UnityEngine.UI.Text PlayerStatusText;
	public UnityEngine.UI.Text EnemyStatusText;
	public UnityEngine.UI.Text GoalStatusText;

	public UnityEngine.UI.Text AIOutputText;

	GameObject cardGeneratorObject;
	UnityEngine.UI.Button DrawCard;
	UnityEngine.UI.Button DiscardHandButton;
	UnityEngine.UI.Text DiscardHand;


	// Use this for initialization
	void Start () {
		//PlayerStatusText = GameObject.Find ("PlayerStatusText").GetComponent<Text> ();
		//EnemyStatusText = GameObject.Find ("EnemyStatusText").GetComponent<Text> ();
		//playerscore = 0;
		//enemyscore = 0;
		UpdateScore ();

	}

	public void checkWin(){
		if (playerscore == goalscore) {
			print ("WIN");
			GameObject.Find ("CardGenerator").GetComponent<cardGenerator> ().playerDiscardHand();
			DiscardHand = GameObject.Find("GUIDiscardHandText").GetComponent<Text>();
			DiscardHand.text = "You Win!";
			DiscardHandButton = GameObject.Find("GUIDiscardHand").GetComponent<Button>();
			DiscardHandButton.interactable = false;
			DrawCard = GameObject.Find("GUICardDraw").GetComponent<Button>();
			DrawCard.interactable = false;

		}
		if (enemyscore == goalscore) {
			print ("LOSE");
			GameObject.Find ("CardGenerator").GetComponent<cardGenerator> ().playerDiscardHand();
			DiscardHand = GameObject.Find("GUIDiscardHandText").GetComponent<Text>();
			DiscardHand.text = "You Lose!";
			DiscardHandButton = GameObject.Find("GUIDiscardHand").GetComponent<Button>();
			DiscardHandButton.interactable = false;
			DrawCard = GameObject.Find("GUICardDraw").GetComponent<Button>();
			DrawCard.interactable = false;
			
		}
	}

	void UpdateScore() {
		PlayerStatusText.text = "You: " + playerscore.ToString ();
		EnemyStatusText.text = "Enemy: " + enemyscore.ToString ();
		GoalStatusText.text = "Goal: " + goalscore.ToString ();
	}

	public void UpdateAIText (string terribleword){

		AIOutputText.text = AIOutputText.text + terribleword;


		// Split the value of the TextOutput and store in array
		string[] OutputTextArray = Regex.Split(AIOutputText.text, "\n");
		
		// Delete old value


		AIOutputText.text = "";
		
		if (OutputTextArray.Length > 10) {
			print (OutputTextArray.Length);
			// Shift array so it looks like it's scrolling up
			for (int i = 1; i < OutputTextArray.Length; i++) {
				OutputTextArray [i - 1] = OutputTextArray [i];
				AIOutputText.text = AIOutputText.text + OutputTextArray [i] + "\n";
			}
		} else {
			print (OutputTextArray.Length);
			for (int i = 0; i < OutputTextArray.Length; i++) {
				AIOutputText.text = AIOutputText.text + OutputTextArray [i] + "\n";
			}
		}

	}



	public void ChangePlayerScore(int score) {
		playerscore = playerscore + score;
		UpdateScore ();
	}

	public void ChangeEnemyScore(int score) {
		enemyscore = enemyscore + score;
		UpdateScore ();
	}


}
