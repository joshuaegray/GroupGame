using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    private float rayLength = 1;

   // public LayerMask physicsLayersToSense;

    public string deathTag;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(deathTag))
        {
            Debug.Log("HIT");
            Destroy(this.gameObject, 0);
            SceneManager.LoadScene("Death Screen");
        }
    }

    // Update is called once per frame
    
    /*
    void Update()
    {
        if (Physics2D.Raycast(transform.position, transform.right, rayLength, physicsLayersToSense))
        {
            Destroy(this.gameObject, 0);
            SceneManager.LoadScene("Death Screen");
        }
        
    }
    
    */
}



/*
     public string deathTag;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(deathTag))
        {
            Debug.Log("Player dying, hit: " + other.gameObject.name);
            Destroy(this.gameObject, 1);
        }
 
 
 */
