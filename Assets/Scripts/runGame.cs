using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Probably should be called point controller or something
public class runGame : MonoBehaviour {

	public int playerscore = new int();
	public int enemyscore = new int();
	public int goalscore = new int();

	public UnityEngine.UI.Text PlayerStatusText;
	public UnityEngine.UI.Text EnemyStatusText;
	public UnityEngine.UI.Text GoalStatusText;

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
	}

	void UpdateScore() {
		PlayerStatusText.text = "You: " + playerscore.ToString ();
		EnemyStatusText.text = "Enemy: " + enemyscore.ToString ();
		GoalStatusText.text = "Goal: " + goalscore.ToString ();
	}

	public void ChangePlayerScore(int score) {
		playerscore = playerscore + score;
		UpdateScore ();
	}


}
