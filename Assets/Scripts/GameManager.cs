using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //--VARIABLES--//
    public int playerHP;
    public int gameDifficulty;
    private float startTime;
    private float currentTime;
    public int playerScore;
    public GameObject player;
    public bool gameIsOver = false;
    public bool gameHasStarted = false;

    public GameObject Countdown3;
    public GameObject Countdown2;
    public GameObject Countdown1;

    public GameObject NextButton;

    public GameObject LeftMovementButton;
    public GameObject RightMovementButton;

    public int testtime;

	// Use this for initialization

	void Start () {
        StartCoroutine(GameStartUITimer());
        startTime = Time.time;
        playerHP = 3;
        NextButton.GetComponent<Button>().enabled = false;
        LeftMovementButton.SetActive(false);
        RightMovementButton.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        gameDiffTimer();
        gameDiffChanger();
        GameOver();

        if(gameHasStarted == true)
        {
            LeftMovementButton.SetActive(true);
            RightMovementButton.SetActive(true);
        }

        if(gameIsOver == true)
        {
            LeftMovementButton.SetActive(false);
            RightMovementButton.SetActive(false);
        }
	}

    void gameDiffTimer()
    {
        currentTime = Time.time - startTime;
    }

    void gameDiffChanger()
    {
        if (currentTime >= 0)
        {
            gameDifficulty = 1;
        }

        if(currentTime >= 30f)
        {
            gameDifficulty = 2;
            Debug.Log("The difficulty has increased from 1 to 2");
        }

        if(currentTime >= 60f)
        {
            gameDifficulty = 3;
            Debug.Log("The difficulty has increased from 2 to 3");
        }

        if (currentTime >= 90f)
        {
            gameDifficulty = 4;
            Debug.Log("The difficulty has increased from 3 to 4");
        }

        if(currentTime >= 120f)
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
            player.GetComponent<PlayerMovement>().enabled = false;
            gameIsOver = true;
            Destroy(Countdown3);
            Destroy(Countdown2);
            Destroy(Countdown1);
            PlayerPrefs.SetInt("CurrentScore", playerScore);

            if (PlayerPrefs.GetInt("CurrentScore") >= PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", playerScore);
            }

            NextButton.GetComponent<Button>().enabled = true;
        }
    }

    IEnumerator GameStartUITimer()
    {
        Countdown3.GetComponent<Text>().enabled = true;
        Countdown2.GetComponent<Text>().enabled = false;
        Countdown1.GetComponent<Text>().enabled = false;
        testtime = 1;
        yield return new WaitForSeconds(1);
        Countdown3.GetComponent<Text>().enabled = false;
        Countdown2.GetComponent<Text>().enabled = true;
        Countdown1.GetComponent<Text>().enabled = false;
        testtime = 2;
        yield return new WaitForSeconds(1);
        Countdown3.GetComponent<Text>().enabled = false;
        Countdown2.GetComponent<Text>().enabled = false;
        Countdown1.GetComponent<Text>().enabled = true;
        testtime = 3;
        yield return new WaitForSeconds(1);
        Countdown3.GetComponent<Text>().enabled = false;
        Countdown2.GetComponent<Text>().enabled = false;
        Countdown1.GetComponent<Text>().enabled = false;
        gameHasStarted = true;
    }
}
