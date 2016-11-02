using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
 level and score manager
 Used for public variables to be tweaked by level designer 
 */
public class LevelManager : MonoBehaviour {

	[SerializeField]
	int scoreToCompleteLevel = 10;
	public int timeToCompleteLevel = 10;

	int score = 0;
	Text scoreText;

	void Awake(){
		GameManager.instance.OnObjectDestructed += IncreaseScore;
		GameManager.instance.OnTimerOut += ShowEnding;

		scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		scoreText.text = "Score: " + score;
	}

	void OnDisable(){
		GameManager.instance.OnObjectDestructed -= IncreaseScore;
		GameManager.instance.OnTimerOut -= ShowEnding;
	}

	private void IncreaseScore(GameObject destructedObj){
		score += 4;
		scoreText.text = "Score: " + score;
		GameManager.instance.score = score;
	}

	private void ShowEnding(){
		if (score >= scoreToCompleteLevel)
			Debug.Log ("Level completed");
		else
			Debug.Log ("Game over. Try again");
	}
}
