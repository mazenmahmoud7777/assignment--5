using UnityEngine;

public class SphereBoundary : MonoBehaviour
{
    public float xLimit = 9f; // Plane half-width
    public float zLimit = 9f; // Plane half-length

    void LateUpdate()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -xLimit, xLimit);
        pos.z = Mathf.Clamp(pos.z, -zLimit, zLimit);

        transform.position = pos;
    }
}
