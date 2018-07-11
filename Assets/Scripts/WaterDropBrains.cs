using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropBrains : MonoBehaviour {
    //Variables
    [SerializeField]
    private int fallSpeed;
    public GameObject gameManager;

    // Update is called once per frame
    void Update () {
        Falling();
        GameOverCheck();
	}

    void Falling()
    {
        this.transform.Translate(new Vector2(0, -fallSpeed) * Time.deltaTime);
    }

    void GameOverCheck()
    {
        if (gameManager.GetComponent<GameManager>().gameIsOver == true)
        {
            Destroy(this);
        }
    }
}
