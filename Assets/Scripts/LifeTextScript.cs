using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeTextScript : MonoBehaviour {

    public int hpValue;
    public GameObject gameManager;
    Text HPCounter;
	// Use this for initialization
	void Start () {
        HPCounter = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        hpValue = gameManager.GetComponent<GameManager>().playerHP;
        HPCounter.text = hpValue.ToString();
	}
}
