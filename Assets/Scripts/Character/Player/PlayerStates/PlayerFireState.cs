using States;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireState : IState
{

    public PlayerController Player;
    public PlayerStateManager StateManager;
    public void StateEnter()
    {
    //Aim animation
    //Fire animation
    }

    public void StateUpdate()
    {
        Player.Fire();

        if (Player.IsMoving())
        {
            StateManager.SwitchState(StateManager.MoveState);
        }
    }
}
