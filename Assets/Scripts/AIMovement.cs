using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    // Script which is attached to Ball gameObject
    [SerializeField] Ball ball;

    // Script which is attached to Paddle gameObject
    [SerializeField] GameObject playerAI;
    Vector3 ballPosition;

    // For AI random movement
    Vector3 randomAIPosition;

    bool ballHasEntered;

    // Start is called before the first frame update
    void Start()
    {
        ballHasEntered = false;
        ballPosition = ball.gameObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ballHasEntered = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Start tracking the ball position if the ball entered the trigger collider
        if (ballHasEntered)
        {
            ballPosition = ball.gameObject.transform.position;
            Debug.Log(ballPosition);

            // Move the playerAI here..
            playerAI.transform.position = new Vector3(playerAI.transform.position.x, ballPosition.y, playerAI.transform.position.z);
        }
    }
}
