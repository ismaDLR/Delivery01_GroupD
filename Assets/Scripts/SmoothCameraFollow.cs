using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private float damping;

    public Transform Target;

    private Vector3 vel = Vector3.zero;

    private void FixedUpdate()
    {
        Vector3 targetPosition = Target.position + offset;
        targetPosition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping);
    }
}
