using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public GameObject LevelBG1;   
    private int CurrentLevel = 1;   
    // Start is called before the first frame update
    void Start()
    {
        LevelBG1.gameObject.SetActive(true);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {        

        if(Input.GetButtonDown("Fire1"))
        {
            SaveScript.LevelNumber = CurrentLevel;
            SceneManager.LoadScene(3);
        }
    }


}
