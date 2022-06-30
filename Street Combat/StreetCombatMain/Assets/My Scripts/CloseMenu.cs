using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.My_Scripts.Interfaces;

public class CloseMenu : MonoBehaviour,ICloseMenu
{
    public int SceneNumber = 0;


    public void CloseWindow()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
