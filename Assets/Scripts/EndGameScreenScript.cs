using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScreenScript : MonoBehaviour {

    public Text currentScore;
    public Text highScore;

    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        currentScore.text = PlayerPrefs.GetInt("CurrentScore", 0).ToString();
    }

}
