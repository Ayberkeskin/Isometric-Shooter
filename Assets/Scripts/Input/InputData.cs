using UnityEngine;

[CreateAssetMenu(menuName ="Input/Input Data",fileName = "Input Data")]
public class InputData : ScriptableObject
{
    [SerializeField] float horizontal;
    [SerializeField] float vertical;
    [SerializeField] Vector3 direction;
    [SerializeField] bool hasInput;

    public float Horizontal { get => horizontal; set => horizontal = value; }
    public float Vertical { get => vertical; set => vertical = value; }
    public Vector3 Direction { get => direction; set => direction = value; }
    public bool HasInput { get => hasInput; set => hasInput = value; }
}
