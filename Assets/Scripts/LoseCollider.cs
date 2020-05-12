using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] string loseSceneName;
    [SerializeField] string winSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check which trigger collider the ball fall into..
        // If the ball fall into player's lose collider, we lose.
        if (gameObject.tag.Equals("Player"))
        {
            Debug.Log("You lose..");
            SceneManager.LoadScene(loseSceneName);
        }
        else if (gameObject.tag.Equals("AI")) // Else if the ball fall into AI's lose collider, we win.
        {
            Debug.Log("You win!");
            SceneManager.LoadScene(winSceneName);
        }
    }
}
