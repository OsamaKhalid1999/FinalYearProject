using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.My_Scripts.Interfaces;

public class MenuButtons : MonoBehaviour,IMenuButtons
{
    public void AiDemo()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(6);
    }

    public void AiDemo2()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(7);
    }

    public void AiDemo3()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(8);
    }

    public void AiDemo4()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(9);
    }

    public void AiDemo5()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(10);
    }

    public void AiDemo6()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(11);
    }

    public void AiDemo7()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(12);
    }

    public void AiDemo8()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(13);
    }

    public void AiDemo9()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(14);
    }

    public void OnePlayerMode()
    {
        SaveScript.Player1Mode = true;
        SceneManager.LoadScene(1);
    }

    public void TwoPlayerMode()
    {
        SaveScript.Player1Mode = false;
        SceneManager.LoadScene(1);
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene(4);
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene(5);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
