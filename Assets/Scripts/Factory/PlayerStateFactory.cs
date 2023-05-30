using States;



namespace Factory
{
    public class PlayerStateFactory
    {
        public static IState CreaterPlayerState(PlayerStates state)
        {
            switch (state)
            {
                case PlayerStates.Move:
                    return new PlayerMoveState();

                case PlayerStates.Search:
                    return new PlayerSearchState();

                case PlayerStates.Fire:
                    return new PlayerFireState();

                default:
                    return null;
            }
        }
    }

}
public enum PlayerStates
{
    Move,
    Search,
    Fire
}