using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    private int scoreText;
    private int score;

    public static ScoreScript S;
    
    // Start is called before the first frame update
    void Start() {
        score = (0.0f);
        scoreText = GetComponent("Text");
        DisplayScore();
        S = this;
    }

    private void IncreaseScore() {
        score++;
        DisplayScore();
    }
    
    private void DecreaseScore() {
        score--;
        DisplayScore();
    }

    public void DisplayScore() {
        scoreText.text = "SCORE: " + score;
    }
}
