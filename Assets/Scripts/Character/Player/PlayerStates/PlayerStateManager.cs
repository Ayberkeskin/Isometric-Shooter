
using States;
using Factory;

    public class PlayerStateManager : StateManager
    {
        public PlayerController Player;

        public PlayerMoveState MoveState;
        public PlayerSearchState SearchState;
        public PlayerFireState FireState;

        public override void Init()
        {

            MoveState =(PlayerMoveState)PlayerStateFactory.CreaterPlayerState(PlayerStates.Move);
            MoveState.Player = Player;
            MoveState.StateManager = this;

            SearchState = (PlayerSearchState)PlayerStateFactory.CreaterPlayerState(PlayerStates.Search);
            SearchState.Player = Player;
            SearchState.StateManager = this;

            FireState = (PlayerFireState)PlayerStateFactory.CreaterPlayerState(PlayerStates.Fire);
            FireState.Player = Player;
            FireState.StateManager = this;

            CurrentState = SearchState;


            base.Init();
        }
    }

