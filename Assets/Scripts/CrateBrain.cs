using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateBrain : MonoBehaviour {

    public GameObject player;
	
	void Update () {
		if(player.GetComponent<PlayerMovement>().playerHasBottle == false)
        {

        }
	}
}
