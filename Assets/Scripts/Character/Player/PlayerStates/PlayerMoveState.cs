using States;
using UnityEngine;

public class PlayerMoveState : IState
{

    public PlayerController Player;
    public PlayerStateManager StateManager;
    public void StateEnter()
    {
        //Move animation
        Player.ResetTarget();
    }

    public void StateUpdate()
    {
        Player.Move();

        if (!Player.IsMoving())
        {
            StateManager.SwitchState(StateManager.SearchState);
        }
    }
}
