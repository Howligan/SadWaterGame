﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    //Variables
    private int speed;
    public GameObject gameManager;

    // Update is called once per frame

    void Update () {
        TranslationMovement();
        PlayerBounds();
	}

    void TranslationMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector2(-speed, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector2(speed, 0) * Time.deltaTime);
        }
    }

    void PlayerBounds()
    {
        if(transform.position.x <= -8.355783f )
        {
            this.transform.position = new Vector2( -8.355783f, transform.position.y);
        }

        if (transform.position.x >= 8.355783f)
        {
            this.transform.position = new Vector2(8.355783f, transform.position.y);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "CleanWater")
        {
            gameManager.GetComponent<GameManager>().playerScore += 10;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "DirtyWater")
        {
            gameManager.GetComponent<GameManager>().playerHP--;
            Destroy(col.gameObject);
        }


    }
}
