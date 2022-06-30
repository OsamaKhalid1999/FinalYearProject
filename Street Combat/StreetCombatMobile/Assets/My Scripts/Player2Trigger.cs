using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Trigger : MonoBehaviour
{
    public Collider Col;
    public float DamageAmt = 0.1f;
    public float PauseSpeed = 0.6f;
    public bool Player2 = true;
    // Update is called once per frame
    void Update()
    {
        //collison boxes enabled on hit happen
        if (Player2 == true)
        {
            if (Player2Actions.HitsP2 == false)
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
                 
                    Player2Actions.HitsP2 = true;
                    SaveScript.Player1Health -= DamageAmt;
                    if (SaveScript.Player1Timer < 2.0f)
                    {
                        SaveScript.Player1Timer += 2.0f;
                    }
                }
            }
        }
        if(SaveScript.P2Reacting == false)
        { 
        if (Player2 == false)
        {
            if (other.gameObject.CompareTag("Player2"))
            {
                //if (EmitFX == true)
                //{
                //    Particles.Play();
                //    Time.timeScale = PauseSpeed;
                //}
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
