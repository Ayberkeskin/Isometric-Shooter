using UnityEngine;

[CreateAssetMenu(menuName ="Character/Character Data")]
public class CharacterData : ScriptableObject
{

    [SerializeField] float moveSpeed;

    [SerializeField] float lookSpeed;

    [SerializeField] float searchRadius;

    public float MoveSpeed { get => moveSpeed; }
    public float LookSpeed { get => lookSpeed;  }
    public float SearchRadius { get => searchRadius; }
}
