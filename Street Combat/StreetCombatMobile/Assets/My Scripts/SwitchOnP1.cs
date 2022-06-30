using System.Collections;
using UnityEngine;
//using TMPro;

public class SwitchOnP1 : MonoBehaviour
{
    //public attributes references to Unity Engine
    public GameObject P1Character;    
    public string P1Name = "Player 1";    
    public GameObject VictoryScreen;
    public float WaitTime = 1.5f;
    private bool Victory = false;

    // Start is called before the first frame update
    void Start()
    {        
        SaveScript.Player1Load = P1Character;  //load p1character     
    }

    // Update is called once per frame
    void Update()
    {
        //conditions to check if player one ore other player has more victories
        if(SaveScript.Player1Wins > 1)
        {
            if (Victory == false)
            {
                Victory = true;
                StartCoroutine(SetVictory());
            }
        }
        if(SaveScript.Player2Wins > 1)
        {
            if(Victory == false)
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
