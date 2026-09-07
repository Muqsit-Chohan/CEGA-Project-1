using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int Speed = 10;

    public int TargetFrameRate = 10;

    private Animator playerAnimator;

    private void Start()
    {
        playerAnimator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        Application.targetFrameRate = TargetFrameRate;

        // Remove Input system using package manager
        float horizontal = Input.GetAxis("Horizontal"); // For Right or Left Input

        // datatype name assigns RHS(=) Class.Method(Parameter)
        float vertical = Input.GetAxis("Vertical"); // For Forward or Backward


        Vector3 direction = horizontal * Vector3.right
            + vertical * Vector3.forward;

        playerAnimator.SetFloat("Speed", Mathf.Abs(horizontal + vertical));

        if (direction.magnitude > 0)
        {
            transform.position += direction * Speed * Time.deltaTime;

            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.LookRotation(direction, Vector3.up), 0.25f);
        }
    }
}
