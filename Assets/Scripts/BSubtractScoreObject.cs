using UnityEngine;

public class BSubtractScoreObject : MonoBehaviour
{
    public ScoreManager scoreManager;  // Reference to the ScoreManager
    public float bounceForce = 10f;    // Force applied to make the object bounce

    private Rigidbody rb;  // Reference to the Rigidbody

    void Start()
    {
        // Get the Rigidbody component of this object
        rb = GetComponent<Rigidbody>();
    }

    // This function will be called when the player touches the object
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))  // Check if the player collided with this object
        {
            scoreManager.SubtractScore(10);  // Subtract 10 points

            // Apply a bounce force away from the player
            Vector3 bounceDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
        }
        else if (other.gameObject.CompareTag("Wall"))  // Check if the object collided with a wall
        {
            // Apply a bounce force away from the wall (using the collision point)
            Vector3 bounceDirection = transform.position - other.contacts[0].point;
            rb.AddForce(bounceDirection.normalized * bounceForce, ForceMode.Impulse);
        }
    }
}
