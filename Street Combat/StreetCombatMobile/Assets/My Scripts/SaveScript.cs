using UnityEngine;


public class SaveScript : MonoBehaviour
{
    //attributes of players health, game timing, victories,player selections
    public static float Player1Health = 1.0f;
    public static float Player2Health = 1.0f;
    public static float Player1Timer = 2.0f;
    public static float Player2Timer = 2.0f;
    public static bool TimeOut = false;
    public static bool Player1Mode = true;
    public static int Player1Wins = 0;
    public static int Player2Wins = 0;
    public static int Round = 0;
    public static string P1Select;
    public static string P2Select;
    public static GameObject Player1Load;
    public static GameObject Player2Load;
    public static int LevelNumber = 1;
    public static float DifficultyAmt = 1.0f;
    public static bool P1Reacting = false;
    public static bool P2Reacting = false;
    private int FrameRateTarget = 120;

    public static bool Player1WalkRight = false;
    public static bool Player1WalkLeft = false;
    public static bool Player1Crouching = false;

    public static bool LightPunch = false;
    public static bool LightKick = false;
    public static bool HeavyPunch = false;
    public static bool HeavyKick = false;
    public static bool Jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        //assigning full health bar to the characters
        Player1Health = 1.0f;
        Player2Health = 1.0f;
        P1Reacting = false;
        P2Reacting = false;

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = FrameRateTarget;

        

    }

    // Update is called once per frame
    void Update()
    {
        if(Application.targetFrameRate != FrameRateTarget)
        {
            Application.targetFrameRate = FrameRateTarget;
        }
        
    }
}
