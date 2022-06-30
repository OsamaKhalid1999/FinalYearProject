using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1MoveRestrictAI : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("P1Left"))
        {
            Player1MoveAI.WalkRightAI = false;
        }
        if (other.gameObject.CompareTag("P1Right"))
        {
            Player1MoveAI.WalkLeftAI = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("P1Left"))
        {
            Player1MoveAI.WalkRightAI = true;
        }
        if (other.gameObject.CompareTag("P1Right"))
        {
            Player1MoveAI.WalkLeftAI = true;
        }
    }

}
