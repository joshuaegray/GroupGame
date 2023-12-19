using System;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    [Header("Movement variables")]
    public float moveSpeedx;

    public float moveSpeedy;

    // constant movement speed
    public float xmin;              // x position limit that triggers reset rightwards
    public Vector3 respawnPosition; // position object will reset to
    private float destroyTime;
  
    void Update()
    {
        // Add a left direction vector to your position every frame
        // Time.deltaTime keeps the moveSpeed at a constant game units per second speed
        transform.position += Vector3.right * moveSpeedx * Time.deltaTime;
        transform.position += Vector3.up*moveSpeedy* Time.deltaTime;
      
        // if you get too far, reset to respawn position
        
            //transform.position = respawnPosition;
        Destroy(this.gameObject, destroyTime );
        
    }

    public void setMovement(float x, float y, float time)
    {
        moveSpeedx = x;
        moveSpeedy = y;
        destroyTime = time;
    }
}