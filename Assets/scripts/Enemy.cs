using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;

    public int Speed = 10;

    private void Update()
    {
        Vector3 distance = Player.position - transform.position;

        Vector3 direction = distance.normalized;

        transform.position += direction * Speed * Time.deltaTime;
    }
}
