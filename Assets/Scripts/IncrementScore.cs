using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrementScore : MonoBehaviour {
    public Text scoreText;
    public int score = 0;
    private int highscore = 0;
    public float lastUpdate=0f;
	// Use this for initialization
	void Start () {
        
        highscore = PlayerPrefs.GetInt("HighScore");
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - lastUpdate >= 1f)
        {
            score++;
            scoreText.text = score.ToString();
            lastUpdate = Time.time;
            PlayerPrefs.SetInt("Score", score);
        }
        if (score > highscore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
	}
    
}
