using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Player")]
    public Transform target;

    [Header("Camera Details")]
    public Vector3 offset = new Vector3(0f, 10f, -10f);
    public float smoothSpeed = 8f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPos;
        transform.LookAt(target);
    }
}
