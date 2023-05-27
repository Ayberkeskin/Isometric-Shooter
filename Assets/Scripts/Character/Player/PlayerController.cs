using UnityEngine;

public class PlayerController : CharacterController
{
    [SerializeField] InputData input;
    protected override void Look()
    {
        modelTransform.forward = Vector3.Lerp(modelTransform.forward,FindLookDirection(),Time.fixedDeltaTime*characterData.LookSpeed);
    }

    protected override void Move()
    {
        if (input.HasInput)
        {

            //2 bouylu bir inputumuz var velocityi'nin kendi deðerini üzerine ekliyoruz ki havada asýlý kalmasýn
            rb.velocity = (input.Direction * characterData.MoveSpeed) +( Vector3.up * rb.velocity.y);

        }
    }

    private Vector3 FindLookDirection()
    {
        Vector3 lookDirection = transform.forward;

        if (input.HasInput)
            lookDirection = input.Direction;
        else if (target!=null)
            lookDirection = target.GetTransform().position - transform.position;

        return lookDirection;
    }

}
