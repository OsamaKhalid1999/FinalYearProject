using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CrouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        if (SaveScript.Player1Crouching == false)
        {
            SaveScript.Player1Crouching = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SaveScript.Player1Crouching = false;
    }
}
