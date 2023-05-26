using UnityEngine;

public class PlayerController : CharacterController
{
    [SerializeField] InputData input;
    public override void Look()
    {
        if (input.HasInput)
        {
            modelTransform.forward = Vector3.Lerp(modelTransform.forward,input.Direction,Time.fixedDeltaTime*characterData.LookSpeed);
        }
    }

    public override void Move()
    {
        if (input.HasInput)
        {

            //2 bouylu bir inputumuz var velocityi'nin kendi deðerini üzerine ekliyoruz ki havada asýlý kalmasýn
            rb.velocity = (input.Direction * characterData.MoveSpeed) +( Vector3.up * rb.velocity.y);

        }
    }
}
