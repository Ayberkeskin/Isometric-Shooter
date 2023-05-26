using UnityEngine;

[CreateAssetMenu(menuName ="Character/Character Data")]
public class CharacterData : ScriptableObject
{

    [SerializeField] float moveSpeed;

    [SerializeField] float lookSpeed;

    public float MoveSpeed { get => moveSpeed; }
    public float LookSpeed { get => lookSpeed;  }
}
