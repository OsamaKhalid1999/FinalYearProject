using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2TriggerAI : MonoBehaviour
{
    public Collider Col;
    public float DamageAmt = 0.1f;//damage amount on hit
    public float PauseSpeed = 0.6f;
    public bool Player2 = true;

    // Update is called once per frame
    void Update()
    {
        //collision boxes enabled on character bodies and this conditions checks weather is a player one character or an AI
        if (Player2 == true)
        {
            if (Player2ActionsAI.HitsAI == false)
            {
                Col.enabled = true;
            }
            else
            {
                Col.enabled = false;
            }
        }
        else
        {
            if (Player1Actions.Hits == false)
            {
                Col.enabled = true;
            }
            else
            {
                Col.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //beahviour of the characters on collision happen
        if (SaveScript.P1Reacting == false)
        {
            if (Player2 == true)
            {
                if (other.gameObject.CompareTag("Player1"))
                {
                    Player2ActionsAI.HitsAI = true;
                    SaveScript.Player1Health -= DamageAmt;
                    if (SaveScript.Player1Timer < 2.0f)
                    {
                        SaveScript.Player1Timer += 2.0f;
                    }
                }
            }
        }
        if (SaveScript.P2Reacting == false)
        {
            if (Player2 == false)
            {
                if (other.gameObject.CompareTag("Player2"))
                {                
                    Player1Actions.Hits = true;
                    SaveScript.Player2Health -= DamageAmt;
                    if (SaveScript.Player2Timer < 2.0f)
                    {
                        SaveScript.Player2Timer += 2.0f;
                    }

                }
            }
        }
    }
}
