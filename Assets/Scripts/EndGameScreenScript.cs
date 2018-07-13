using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScreenScript : MonoBehaviour {

    public Text currentScore;
    public Text highScore;
    public int cScore;
    public int hScore;

    private void Start()
    {
        hScore = PlayerPrefs.GetInt("HighScore");
        cScore = PlayerPrefs.GetInt("CurrentScore");

        if(hScore < cScore)
        {
            PlayerPrefs.SetInt("HighScore",cScore);
        }

        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        currentScore.text = PlayerPrefs.GetInt("CurrentScore", 0).ToString();
    }

}
