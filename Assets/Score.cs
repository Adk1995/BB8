using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {
	public Text scoreText;
	public int maxScore=5;
	int score;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	public void AddPoint () {
		score++;
		if (score != maxScore)
			scoreText.text = "Score: " + score;
		else
			scoreText.text = "You won!";
	}
}
