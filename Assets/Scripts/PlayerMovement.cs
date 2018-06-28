using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    //Variables
    public int speed;

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
            Destroy(col.gameObject);
        }


    }
}
