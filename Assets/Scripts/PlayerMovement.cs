using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    //Variables
    private int speed;
    public GameObject gameManager;
    public Rigidbody2D playerRbody;
    public bool playerHasBottle;
    public int playerWaterCount;

    public GameObject emptyBottle;
    public GameObject bottle1;
    public GameObject bottle2;
    public GameObject bottle3;

    public enum PlayerState { NoBottle, BottleEmpty, Bottle1, Bottle2, BottleFull}
    public PlayerState currentPlayerState;

    void Start()
    {
        playerRbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update () {
        TranslationMovement();
        PlayerBounds();

        switch (currentPlayerState)
        {
            case PlayerState.NoBottle:
                PlayerHasNoBottle();
                break;
            case PlayerState.BottleEmpty:
                Player03Bottle();
                break;  
            case PlayerState.Bottle1:
                Player13Bottle();
                break;
            case PlayerState.Bottle2:
                Player23Bottle();
                break;
            case PlayerState.BottleFull:
                Player33Bottle();
                break;
        }
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
            if (currentPlayerState == PlayerState.BottleEmpty)
            {
                currentPlayerState = PlayerState.Bottle1;
                Destroy(col.gameObject);
            }
            else if (currentPlayerState == PlayerState.Bottle1)
            {
                currentPlayerState = PlayerState.Bottle2;
                Destroy(col.gameObject);
            }
            else if (currentPlayerState == PlayerState.Bottle2)
            {
                currentPlayerState = PlayerState.BottleFull;
                Destroy(col.gameObject);
            }
        }

        if (col.gameObject.tag == "DirtyWater")
        {
            currentPlayerState = PlayerState.NoBottle;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Crate")
        {
            if(playerHasBottle == false && playerWaterCount == 0)
            {
                currentPlayerState = PlayerState.BottleEmpty;
            }
        }

        if(col.gameObject.tag == "Truck")
        {
            if(playerHasBottle == true && playerWaterCount == 3)
            {
                currentPlayerState = PlayerState.NoBottle;
            }
        }
    }

    void PlayerHasNoBottle()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
        playerHasBottle = false;
        playerWaterCount = 0;
        emptyBottle.SetActive(false);
        bottle1.SetActive(false);
        bottle2.SetActive(false);
        bottle3.SetActive(false);
    }

    void Player03Bottle()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;

        playerHasBottle = true;
        playerWaterCount = 0;
        emptyBottle.SetActive(true);
        bottle1.SetActive(false);
        bottle2.SetActive(false);
        bottle3.SetActive(false);
    }

    void Player13Bottle()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
        playerHasBottle = true;
        playerWaterCount = 1;
        emptyBottle.SetActive(false);
        bottle1.SetActive(true);
        bottle2.SetActive(false);
        bottle3.SetActive(false);
    }

    void Player23Bottle()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
        playerHasBottle = true;
        playerWaterCount = 2;
        emptyBottle.SetActive(false);
        bottle1.SetActive(false);
        bottle2.SetActive(true);
        bottle3.SetActive(false);
    }

    void Player33Bottle()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
        playerHasBottle = true;
        playerWaterCount = 3;
        emptyBottle.SetActive(false);
        bottle1.SetActive(false);
        bottle2.SetActive(false);
        bottle3.SetActive(true);
    }
}
