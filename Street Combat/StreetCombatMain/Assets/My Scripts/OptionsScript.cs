using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using Assets.My_Scripts.Interfaces;

public class OptionsScript : MonoBehaviour,IOptionsScript
{
    public void DifficultyEasy()
    {
        SaveScript.DifficultyAmt = 3.0f;
    }

    public void DifficultyStandard()
    {
        SaveScript.DifficultyAmt = 2.0f;
    }

    public void DifficultyExpert()
    {
        SaveScript.DifficultyAmt = 0.5f;
    }
   
}
