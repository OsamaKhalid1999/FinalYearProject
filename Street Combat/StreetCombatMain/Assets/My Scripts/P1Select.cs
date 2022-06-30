﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.My_Scripts.Interfaces;
using TMPro;

public class P1Select : MonoBehaviour,ISelect
{
    public int MaxIcons = 3;
    public int IconsPerRow = 3;
    public int MaxRows = 1;

    public GameObject EveP1;
    public GameObject VanguardP1;    
    public GameObject MariaP1;
    public GameObject EveP1Text;
    public GameObject VanguardP1Text;
    public GameObject MariaP1Text;    

    //public TextMeshProUGUI Player1Name;

    public string CharacterSelectionP1;

    private int IconNumber = 1;
    private int RowNumber = 1;
    private float PauseTime = 1.0f;
    public float TimerMax = 0.6f;
    private bool TimeCountDown = false;
    private bool ChangeCharacter = false;

    //public int Scene = 1;
    // Start is called before the first frame update
    void Start()
    {
        SaveScript.Round = 0;
        SaveScript.Player1Wins = 0;
        SaveScript.Player2Wins = 0;
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
                EveP1.gameObject.SetActive(true);
                EveP1Text.gameObject.SetActive(true);
                //Player1Name.text = "Eve";
                CharacterSelectionP1 = "EveP1";
                ChangeCharacter = false;
            }
            if (IconNumber == 2)
            {
                SwitchOff();
                VanguardP1.gameObject.SetActive(true);
                VanguardP1Text.gameObject.SetActive(true);
               // Player1Name.text = "Vanguard";
                CharacterSelectionP1 = "VanguardP1";
                ChangeCharacter = false;
            }
            if (IconNumber == 3)
            {
                SwitchOff();
                MariaP1.gameObject.SetActive(true);
                MariaP1Text.gameObject.SetActive(true);
                //Player1Name.text = "Maria";
                CharacterSelectionP1 = "MariaP1";
                ChangeCharacter = false;
            }
           
        }

        if(Input.GetButtonDown("Fire1"))
        {
            SaveScript.P1Select = CharacterSelectionP1;
            //MyPlayer.Play();
            NextPlayer();
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

        if(Input.GetAxis("Horizontal") > 0)
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
        if (Input.GetAxis("Horizontal") < 0)
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
        EveP1.gameObject.SetActive(false);
        VanguardP1.gameObject.SetActive(false);
        MariaP1.gameObject.SetActive(false);      
       
        EveP1Text.gameObject.SetActive(false);
        VanguardP1Text.gameObject.SetActive(false);
        MariaP1Text.gameObject.SetActive(false);
        
    }

    public void NextPlayer()
    {
        EveP1Text.gameObject.SetActive(false);
        VanguardP1Text.gameObject.SetActive(false);        
        MariaP1Text.gameObject.SetActive(false); 


        if (SaveScript.Player1Mode == true)
        {
            this.gameObject.GetComponent<CPUSelect>().enabled = true;
            this.gameObject.GetComponent<P1Select>().enabled = false;
        }
        if (SaveScript.Player1Mode == false)
        {
            this.gameObject.GetComponent<P2Select>().enabled = true;
            this.gameObject.GetComponent<P1Select>().enabled = false;
        }
    }
}
