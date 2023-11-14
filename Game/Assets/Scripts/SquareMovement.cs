using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    [Header("Movement variables")]
    public float moveSpeed;         // constant movement speed
    public float xmin;              // x position limit that triggers reset rightwards
    public Vector3 respawnPosition; // position object will reset to
  
    void Update()
    {
        // Add a left direction vector to your position every frame
        // Time.deltaTime keeps the moveSpeed at a constant game units per second speed
        transform.position -= Vector3.right * moveSpeed * Time.deltaTime;
      
        // if you get too far, reset to respawn position
        if (transform.position.x < xmin)
        {
            transform.position = respawnPosition;
        }
    }
}