using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] InputData input;
    [SerializeField] FloatingJoystick joystick;

    void Update()
    {
        input.Horizontal = joystick.Horizontal;
        input.Vertical = joystick.Vertical;

    }
}
