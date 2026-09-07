using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int Speed = 10;
    public int TargetFrameRate = 60;

    void Update()
    {
        Application.targetFrameRate = TargetFrameRate;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = horizontal * Vector3.right
            + vertical * Vector3.forward;

        if (direction.magnitude > 0)
        {
            transform.position += direction * Speed * Time.deltaTime;

            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(direction, Vector3.up),
                0.25f
            );
        }
    }
}