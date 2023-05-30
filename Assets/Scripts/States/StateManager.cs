using UnityEngine;

namespace States
{
    public abstract class StateManager : MonoBehaviour
    {
        public IState CurrentState;

        private void Start()
        {
            Init();
        }

        private void Update()
        {
            CurrentState.StateUpdate();
        }

        public virtual void SwitchState(IState state)
        {
            CurrentState = state;
        }
        public virtual void Init()
        {
            CurrentState.StateEnter();
        }

    }

}
