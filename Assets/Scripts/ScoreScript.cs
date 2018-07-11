using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public int scoreValue = 0;
    public GameObject gameManager;
    Text ScoreCounter;

	// Use this for initialization
	void Start () {
        ScoreCounter = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreValue = gameManager.GetComponent<GameManager>().playerScore;
        ScoreCounter.text = scoreValue.ToString();
	}
}
