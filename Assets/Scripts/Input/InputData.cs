using UnityEngine;

[CreateAssetMenu(menuName ="Input/Input Data",fileName = "Input Data")]
public class InputData : ScriptableObject
{
    [SerializeField] float horizontal;
    [SerializeField] float vertical;

    public float Horizontal { get => horizontal; set => horizontal = value; }
    public float Vertical { get => vertical; set => vertical = value; }
}
