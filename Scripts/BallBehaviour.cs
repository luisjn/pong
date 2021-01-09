using System;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private float posDiff;
    
    public bool gameStarted;
    public Rigidbody2D ballRigidbody;
    public Transform paddleTransform;

    private void Start()
    {
        posDiff = paddleTransform.position.x - transform.position.x;
    }

    private void Update()
    {
        if (!gameStarted)
        {
            transform.position = new Vector3(paddleTransform.position.x - posDiff, paddleTransform.position.y, paddleTransform.position.y);

            if (Input.GetMouseButtonDown(0))
            {
                ballRigidbody.velocity = new Vector2(8, 8);
                gameStarted = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GetComponent<AudioSource>().Play();
    }
}
