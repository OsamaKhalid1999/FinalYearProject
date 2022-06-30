using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    public bool LeftButton = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (LeftButton == false)
        {
            if (SaveScript.Player1WalkRight == false)
            {
                SaveScript.Player1WalkRight = true;
                SaveScript.Player1WalkLeft = false;
            }
        }

        if (LeftButton == true)
        {
            if (SaveScript.Player1WalkLeft == false)
            {
                SaveScript.Player1WalkRight = false;
                SaveScript.Player1WalkLeft = true;
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (LeftButton == false)
        {
            if (SaveScript.Player1WalkRight == true && SaveScript.Player1WalkLeft == false)
            {
                SaveScript.Player1WalkRight = false;
            }
        }

        if (LeftButton == true)
        {
            if (SaveScript.Player1WalkLeft == true && SaveScript.Player1WalkRight == false)
            {
                SaveScript.Player1WalkLeft = false;
            }
        }
    }
}

