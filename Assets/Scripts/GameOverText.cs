using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour {
    public GameObject gameManager;
    Text GoText;

	// Use this for initialization
	void Start () {
        GoText = GetComponent<Text>();
        GoText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameManager.GetComponent<GameManager>().gameIsOver == true)
        {
            GoText.enabled = true;
        }
	}
}
