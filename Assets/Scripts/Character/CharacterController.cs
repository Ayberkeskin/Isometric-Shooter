using Targets;
using UnityEngine;

public abstract class CharacterController : MonoBehaviour
{
    public CharacterData characterData;

    public Rigidbody rb;

    public Transform modelTransform;

    protected ITarget target = null;

    private RaycastHit[] raycastHits = new RaycastHit[5];

    public LayerMask layer;

    private void FixedUpdate()
    {
        Move();
        Look();
        Search();
    }

    protected abstract void Move();

    protected abstract void Look();

    protected virtual void Search()
    { 
        int hitCount= Physics.SphereCastNonAlloc(modelTransform.position, characterData.SearchRadius, Vector3.up, raycastHits, Mathf.Infinity, layer);

        if (hitCount<=0)
        {
            target = null;
            return;
        }

        Transform nearestTransform = FindNearestTransform(hitCount);
        target = TargetManager.FindTargetFromTransform(nearestTransform);
    }

    private Transform FindNearestTransform(int hitCount)
    {
        Transform nearestTransform = raycastHits[0].transform;

        for (int i = 1; i < hitCount; i++)
        {
            Transform nextTransform = raycastHits[i].transform;

            float nearestTargetDistance = (modelTransform.position - nearestTransform.position).sqrMagnitude;
            float nextTargetDistance = (modelTransform.position - nextTransform.position).sqrMagnitude;

            if (nextTargetDistance<nearestTargetDistance)
            {
                nearestTransform = nextTransform;
            }
        }

        return nearestTransform;
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        if (target!=null)
            Gizmos.color = new Color(0f,1f,0f,0.15f);
        else
            Gizmos.color = new Color(1f, 0f, 0f, 0.15f);

        Gizmos.DrawSphere(modelTransform.position, characterData.SearchRadius);

        if (target!=null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(modelTransform.position,target.GetTransform().position);
        }
    }

#endif


}
