using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Player2MoveAI player2MoveAi = animator.GetComponent<Player2MoveAI>();
        player2MoveAi.Update();
        Player1MoveAI player1MoveAi = animator.GetComponent<Player1MoveAI>();
        player1MoveAi.Update();
    }


}
