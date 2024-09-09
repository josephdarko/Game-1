using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
     public PlayerMovement movement;// Reference to the PlayerMovement script

    void OnCollisionEnter(Collision collisionInfo) 
    {
        // Check if the collided object has the tag "Obstacle"
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("We hit an obstacle"); // Log the message to the console
            movement.enabled = false; // Disable the PlayerMovement script

            //correctly find the GameManager and call the Endgame

            FindObjectOfType<GameManager>().EndGame();

        }

        
    }
}
