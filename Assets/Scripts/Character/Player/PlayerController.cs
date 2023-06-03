using UnityEngine;
using Weapons;

public class PlayerController : CharacterController
{
    [SerializeField] InputData input;
    [SerializeField] WeaponHandler weaponHandler;

    private const float AIM_DIFFRENCE = 0.001f;
    protected override void Look(Vector3 lookDirection)
    {
        modelTransform.forward = Vector3.Lerp(modelTransform.forward, lookDirection, Time.fixedDeltaTime*characterData.LookSpeed);
    }

    public override void Move()
    {
        Look(input.Direction);

        rb.velocity = (input.Direction * characterData.MoveSpeed) +( Vector3.up * rb.velocity.y);
    }

    public override bool IsMoving()
    {
        return input.HasInput;
    }

    public override void Fire()
    {
        Vector3 lookDirection = (target.GetTransform().position-transform.position).normalized;

        Look(lookDirection);

        bool canFire = (modelTransform.forward-lookDirection).sqrMagnitude< AIM_DIFFRENCE ? true:false;

        if (!canFire)
            return;

        IWeapon weapon = weaponHandler.GetWeapon();
        weapon.Fire();

    }
}
