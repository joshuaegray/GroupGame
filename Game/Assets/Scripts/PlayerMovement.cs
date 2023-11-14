using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 mousePos;
    //controls the player y
    private float playerY;
    private float playerX;
    private Camera cam;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {

        cam = Camera.main;
        playerY = transform.position.y;
        playerX = transform.position.x;
        movementSpeed = 15;

    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        if (mousePos.y > transform.position.y )
        {
            playerY += movementSpeed * Time.deltaTime;
        }
        
        if (mousePos.x > transform.position.x - 1)
        {
            playerX += movementSpeed * Time.deltaTime;
        }
        
        
        if (mousePos.y < transform.position.y )
        {
            playerY -= movementSpeed * Time.deltaTime;
        }
        
        
        if (mousePos.x < transform.position.x - 1)
        {
            playerX -= movementSpeed * Time.deltaTime;
        }
        
        transform.position = new Vector3( playerX ,playerY,  0);
    

}
}
