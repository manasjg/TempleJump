using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();
        GameObject.Find("HighScoreValue").GetComponent<Text>().text = PlayerPrefs.GetInt("HighScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
