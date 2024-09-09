using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // Reference to the Rigidbody component
    public float forwardForce = 200f; // Forward force applied to the player
    public float sidewaysForce = 200f; // Sideways force applied to the player

    void FixedUpdate()
    {
        // Add a constant forward force
        rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

        // Check for right movement (D key)
        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);

         
        }

        // Check for left movement (A key)
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y< -1f)
        {
                        FindObjectOfType<GameManager>().EndGame();

        }
    }
}