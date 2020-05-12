using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject playerOne;
    [SerializeField] float pushX = 5f;
    [SerializeField] float pushY = 10f;

    Vector3 diffPosition;

    bool ballHasLaunched;

    // Start is called before the first frame update
    void Start()
    {
        ballHasLaunched = false;

        // Get the initial difference in position between paddle and ball
        diffPosition = playerOne.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ballHasLaunched)
        {
            // Make ball position to follow the paddle, reduced with the difference
            transform.position = playerOne.transform.position - diffPosition;

            launchBallOnMouseClick();
        }
    }

    private void launchBallOnMouseClick()
    {
        // Release the ball on left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            ballHasLaunched = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(pushX, pushY);
        }
    }
}
