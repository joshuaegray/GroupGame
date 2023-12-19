using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public string levelName;
    public float movementSpeed;

    private Vector2 currMovement;
    private Vector3 mousePos;
    private Camera cam;
    private Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

      
            currMovement = (mousePos - transform.position).normalized * movementSpeed;
            transform.up = mousePos - transform.position;
            

          
            


        


        
    }
    
    public void FixedUpdate()
    {
      // rb.MovePosition(rb.position + new Vector2(playerX, playerY));
      // rb.position = new Vector2(playerX, playerY);
      
      rb.velocity = currMovement;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
