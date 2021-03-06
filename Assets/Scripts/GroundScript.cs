﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

    public GameObject gameManager;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if(gameManager.GetComponent<GameManager>().gameIsOver == true)
        {
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "CleanWater")
        {
            gameManager.GetComponent<GameManager>().playerHP--;
            Debug.Log("You lost a heart!");
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "DirtyWater")
        {
            Destroy(col.gameObject);
        }
    }
}
