using UnityEngine;

public class FollowTargetCamera : MonoBehaviour
{
    public Transform Target;
    public float RotationFolowForce = 5f;

    void LateUpdate()
	{
        var vector = Vector3.forward;
        var dir = Target.rotation * Vector3.forward;
		dir.y = 0f;
        if (dir.magnitude > 0f) vector = dir / dir.magnitude; 
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(vector), RotationFolowForce * Time.deltaTime);
	}
}

