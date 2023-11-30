using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 mousePos;

    //controls the player y
    private float playerY;
    private float playerX;
    private Camera cam;
    public string levelName;
    public float movementSpeed;

    public LayerMask targetLayer;

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
        if (!(playerY > mousePos.y - 1 && playerY < mousePos.y + 1))
        {
            if (mousePos.y > transform.position.y)
            {
                playerY += movementSpeed * Time.deltaTime;
            }

            if (mousePos.y < transform.position.y)
            {

                playerY -= movementSpeed * Time.deltaTime;
            }
        }





        if (!(playerX > mousePos.x - 1 && playerX < mousePos.x + 1))
        {
            if (mousePos.x - 1 > transform.position.x)
            {
                playerX += movementSpeed * Time.deltaTime;
            }

            if (mousePos.x - 1 < transform.position.x)
            {
                playerX -= movementSpeed * Time.deltaTime;
            }
        }




        if (Physics2D.Raycast(transform.position, transform.right, 1, targetLayer))
        {
            SceneManager.LoadScene(levelName);
        }

        
        
        transform.position = new Vector3(playerX, playerY, 0);

    }
}
