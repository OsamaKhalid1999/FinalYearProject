using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1TriggerAI : MonoBehaviour
{
    public Collider Col;
    public float DamageAmt = 0.1f;
    public float PauseSpeed = 0.6f;
    public bool Player2 = true;
    // Update is called once per frame
    void Update()
    {
        
        if (Player1ActionsAI.HitsAI == false)
        {
            Col.enabled = true;
        }
        else
        {
            Col.enabled = false;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (SaveScript.P2Reacting == false)
        {
            if (other.gameObject.CompareTag("Player2"))
            {
                   
                Player1ActionsAI.HitsAI = true;
                SaveScript.Player2Health -= DamageAmt;
                if (SaveScript.Player2Timer < 2.0f)
                {
                    SaveScript.Player2Timer += 2.0f;
                }

            }
           
        }
    }
}
