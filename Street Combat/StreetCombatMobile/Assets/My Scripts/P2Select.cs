using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;
using UnityEngine.SceneManagement;
using Assets.My_Scripts.Interfaces;

public class P2Select : MonoBehaviour,ISelect
{
    public int MaxIcons = 3;
    public int IconsPerRow = 3;
    public int MaxRows = 1;

    public GameObject EveP2;
    public GameObject VanguardP2;
    public GameObject MariaP2;
    public GameObject EveP2Text;
    public GameObject VanguardP2Text;
    public GameObject MariaP2Text;

    public string CharacterSelectionP2;

    private int IconNumber = 1;
    private int RowNumber = 1;
    private float PauseTime = 1.0f;
    public float TimerMax = 0.6f;
    private bool TimeCountDown = false;
    private bool ChangeCharacter = false;


    public int Scene = 1;

    // Start is called before the first frame update
    void Start()
    {
        ChangeCharacter = true;
        Time.timeScale = 0.6f;
     
        PauseTime = TimerMax;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(SaveScript.P1Select);
        if (ChangeCharacter == true)
        {
            if (IconNumber == 1)
            {
                SwitchOff();
                EveP2.gameObject.SetActive(true);
                EveP2Text.gameObject.SetActive(true);
                //Player2Name.text = "Eve";
                CharacterSelectionP2 = "EveP2";
                ChangeCharacter = false;
            }
            if (IconNumber == 2)
            {
                SwitchOff();
                VanguardP2.gameObject.SetActive(true);
                VanguardP2Text.gameObject.SetActive(true);
                //Player2Name.text = "Vanguard";
                CharacterSelectionP2 = "VanguardP2";
                ChangeCharacter = false;
            }            
            if (IconNumber == 3)
            {
                SwitchOff();
                MariaP2.gameObject.SetActive(true);
                MariaP2Text.gameObject.SetActive(true);
                //Player2Name.text = "Maria";
                CharacterSelectionP2 = "MariaP2";
                ChangeCharacter = false;
            }           

        }

        if(Input.GetButtonDown("Fire1P2"))
        {
            SaveScript.P2Select = CharacterSelectionP2;
            //MyPlayer.Play();
            SceneManager.LoadScene(Scene);
        }

        if(TimeCountDown == true)
        {
            if(PauseTime > 0.1f)
            {
                PauseTime -= 1.0f * Time.deltaTime;
            }
            if(PauseTime <= 0.1f)
            {
                PauseTime = TimerMax;
                TimeCountDown = false;
            }
        }

        if(Input.GetAxis("HorizontalP2") > 0)
        {
            if(PauseTime == TimerMax)
            {
                if(IconNumber < IconsPerRow * RowNumber)
                {
                    IconNumber++;
                    ChangeCharacter = true;
                    TimeCountDown = true;
                }
            }
        }
        if (Input.GetAxis("HorizontalP2") < 0)
        {
            if (PauseTime == TimerMax)
            {
                if (IconNumber > IconsPerRow * (RowNumber - 1) +1)
                {
                    IconNumber--;
                    ChangeCharacter = true;
                    TimeCountDown = true;
                }
            }
        }
       
    }

    public void SwitchOff()
    {
        EveP2.gameObject.SetActive(false);       
        MariaP2.gameObject.SetActive(false);       
        VanguardP2.gameObject.SetActive(false);
        EveP2Text.gameObject.SetActive(false);
        MariaP2Text.gameObject.SetActive(false);      
        VanguardP2Text.gameObject.SetActive(false);
    }
}
