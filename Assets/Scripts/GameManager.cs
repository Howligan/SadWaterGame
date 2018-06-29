using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //--VARIABLES--//
    public int playerHP;
    public int gameDifficulty;
    private float startTime;
    private float currentTime;
    public int playerScore;

	// Use this for initialization
	void Start () {
        gameDifficulty = 1;
        startTime = Time.time;
        playerHP = 3;
	}
	
	// Update is called once per frame
	void Update () {
        gameDiffTimer();
        gameDiffChanger();
        GameOver();
	}

    void gameDiffTimer()
    {
        currentTime = Time.time - startTime;
    }

    void gameDiffChanger()
    {
        if(currentTime >= 10f)
        {
            gameDifficulty = 2;
            Debug.Log("The difficulty has increased from 1 to 2");
        }

        if(currentTime >= 20f)
        {
            gameDifficulty = 3;
            Debug.Log("The difficulty has increased from 2 to 3");
        }

        if (currentTime >= 30f)
        {
            gameDifficulty = 4;
            Debug.Log("The difficulty has increased from 3 to 4");
        }

        if(currentTime >= 40f)
        {
            gameDifficulty = 5;
            Debug.Log("The difficulty has increased from 4 to 5");
        }
    }

    void GameOver()
    {
        if(playerHP <= 0)
        {
            Debug.Log("Game is over!");
        }
    }
}
