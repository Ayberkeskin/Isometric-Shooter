using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterController : MonoBehaviour
{
    public CharacterData characterData;

    public Rigidbody rb;

    public Transform modelTransform;


    private void FixedUpdate()
    {
        Move();
        Look();
    }

    public abstract void Move();

    public abstract void Look();

}
