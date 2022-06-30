using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{

    public void LightKickButton()
    {
        SaveScript.LightKick = true;
    }

    public void LightPunchButton()
    {
        SaveScript.LightPunch = true;
    }

    public void HeavyKickButton()
    {
        SaveScript.HeavyKick = true;
    }

    public void HeavyPunchButton()
    {
        SaveScript.HeavyPunch = true;
    }

    public void JumpButton()
    {
        SaveScript.Jumping = true;
    }
}
