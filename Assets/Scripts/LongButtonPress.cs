using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongButtonPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public bool pointerDown;
    public GameObject player;

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDown = false;
    }

    private void FixedUpdate()
    {
        if (pointerDown)
        {
            if (this.gameObject.name == "LeftMovementButton")
            {
                player.GetComponent<PlayerMovement>().MoveLeft();
            }
            else if (this.gameObject.name == "RightMovementButton")
            {
                player.GetComponent<PlayerMovement>().MoveRight();
            }
        }
    }
}
