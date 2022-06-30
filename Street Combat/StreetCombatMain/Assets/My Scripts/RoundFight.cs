using System.Collections;

using UnityEngine;

public class RoundFight : MonoBehaviour
{
    public GameObject Round1Text;
    public GameObject Round2Text;
    public GameObject Round3Text;
    public GameObject FightText;//text about round counts and winning player text

    public float PauseTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Round1Text.gameObject.SetActive(false);
        Round2Text.gameObject.SetActive(false);
        Round3Text.gameObject.SetActive(false);
        FightText.gameObject.SetActive(false);
        StartCoroutine(RoundSet());
    }

    IEnumerator RoundSet()
    {
        yield return new WaitForSeconds(0.2f);
        //conditions checked for each round to be played
        if (SaveScript.Round == 1)
        {
            yield return new WaitForSeconds(0.4f);
            Round1Text.gameObject.SetActive(true);           
            yield return new WaitForSeconds(PauseTime);
            Round1Text.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            FightText.gameObject.SetActive(true);          
            yield return new WaitForSeconds(PauseTime);
            FightText.gameObject.SetActive(false);        
            SaveScript.TimeOut = false;
            this.gameObject.SetActive(false);
        }
        if (SaveScript.Round == 2)
        {
            yield return new WaitForSeconds(0.4f);
            Round2Text.gameObject.SetActive(true);          
            yield return new WaitForSeconds(PauseTime);
            Round2Text.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            FightText.gameObject.SetActive(true);        
            yield return new WaitForSeconds(PauseTime);
            FightText.gameObject.SetActive(false);      
            SaveScript.TimeOut = false;
            this.gameObject.SetActive(false);
        }
        if (SaveScript.Round == 3)
        {
            yield return new WaitForSeconds(0.4f);
            Round3Text.gameObject.SetActive(true);          
            yield return new WaitForSeconds(PauseTime);
            Round3Text.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            FightText.gameObject.SetActive(true);           
            yield return new WaitForSeconds(PauseTime);
            FightText.gameObject.SetActive(false);          
            SaveScript.TimeOut = false;
            this.gameObject.SetActive(false);
        }

    }

}
