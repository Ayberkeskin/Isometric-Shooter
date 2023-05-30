using UnityEngine;
using States;

public class PlayerSearchState : IState
{

    public PlayerController Player;
    public PlayerStateManager StateManager;
    public void StateEnter()
    {
      //Idle animation
    }

    public void StateUpdate()
    {
        Player.Search();

        if (Player.IsMoving())
        {
            StateManager.SwitchState(StateManager.MoveState);
        }
        else if (Player.HasTarget())
        {
            StateManager.SwitchState(StateManager.FireState);
        }
    }
}
