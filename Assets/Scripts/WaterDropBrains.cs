using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropBrains : MonoBehaviour {
    //Variables
    [SerializeField]
    public int fallSpeed;
	
	// Update is called once per frame
	void Update () {
        Falling();
	}

    void Falling()
    {
        this.transform.Translate(new Vector2(0, -fallSpeed) * Time.deltaTime);
    }
}
