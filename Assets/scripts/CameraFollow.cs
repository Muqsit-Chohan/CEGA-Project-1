using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;

    public float smoothingTime = 2;

    public Vector3 Offset = Vector3.zero;
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,
            Player.transform.position + Offset, smoothingTime * Time.deltaTime);
    }
}
