using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] InputData input;
    [SerializeField] FloatingJoystick joystick;

    void Update()
    {
        input.Horizontal = joystick.Horizontal;
        input.Vertical = joystick.Vertical;

        input.Direction = new Vector3(input.Horizontal,0, input.Vertical);

        input.HasInput = (input.Direction.magnitude > 0f ? true:false);

       
    }
}
