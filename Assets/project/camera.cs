using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;       // Your player or sphere
    public Vector3 offset = new Vector3(0f, 5f, -7f);  // Camera position relative to player
    public float smoothSpeed = 0.15f;                  // How smooth the camera follows

    void LateUpdate()
    {
        if (!target) return;

        // Desired position based on target position + offset
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move camera toward desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        // Make camera look at player
        transform.LookAt(target);
    }
}
