using System.Collections;
using UnityEngine;
//using TMPro;

public class SwitchOnP2 : MonoBehaviour
{
    
    public GameObject P2Character;
    public GameObject AICharacter;
    public string P2Name = "Player 2";   
    public GameObject VictoryScreen;
    public float WaitTime = 1.5f;
    private bool Victory = false;

    // Start is called before the first frame update
    void Start()
    {
        
        if (SaveScript.Player1Mode == false)
        {
            SaveScript.Player2Load = P2Character;
        }
        if (SaveScript.Player1Mode == true)
        {
            SaveScript.Player2Load = AICharacter;
        }
    }

    void Update()
    {
        //check which players has more vcitories
        if (SaveScript.Player2Wins > 1)
        {
            if (Victory == false)
            {
                Victory = true;
                StartCoroutine(SetVictory());
            }
        }
        if (SaveScript.Player1Wins > 1)
        {
            if (Victory == false)
            {
                Victory = true;
                
            }
        }
    }

    IEnumerator SetVictory()
    {
        yield return new WaitForSeconds(WaitTime);
        VictoryScreen.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

 
}
