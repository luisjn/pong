using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ball;
    public float speed;

    private void Update()
    {
        if (ball.GetComponent<BallBehaviour>().gameStarted)
        {
            if (transform.position.y < ball.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            } else if (transform.position.y > ball.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
            }
        }
    }
}
