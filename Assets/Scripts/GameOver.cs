﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("End");
            int score = GameObject.Find("ScoreKeeper").GetComponent<IncrementScore>().score;
            PlayerPrefs.SetInt("Score", score);
        }
    }
}
