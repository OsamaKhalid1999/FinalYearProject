using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSpawn : MonoBehaviour
{
    private GameObject Player1;
    private GameObject Player2;
    private GameObject Player1Character;
    private GameObject Player2Character;
    public Transform Player1Spawn;
    public Transform Player2Spawn;
    public GameObject Background;
    public Material NewMaterial;
  

    public Material BG1; 

    public int Scene = 0;

    // Start is called before the first frame update
    void Start()
    {
        //MyPlayer = GetComponent<AudioSource>();
        if (SaveScript.LevelNumber == 1)
        {
            NewMaterial = BG1;
            
        }        
        Player1 = GameObject.Find(SaveScript.P1Select);
        Player1.gameObject.GetComponent<SwitchOnP1>().enabled = true;
        Player2 = GameObject.Find(SaveScript.P2Select);
        Player2.gameObject.GetComponent<SwitchOnP2>().enabled = true;
        Background.gameObject.GetComponent<Renderer>().material = NewMaterial;
        StartCoroutine(SpawnPlayers());

    }

    IEnumerator SpawnPlayers()
    {
        yield return new WaitForSeconds(0.1f);
        Player1Character = SaveScript.Player1Load;
        Player2Character = SaveScript.Player2Load;
        Instantiate(Player1Character, Player1Spawn.position, Player1Spawn.rotation);
        Instantiate(Player2Character, Player2Spawn.position, Player2Spawn.rotation);
    }

    public void BackToSelection()
    {
        SceneManager.LoadScene(Scene);
    }

}
