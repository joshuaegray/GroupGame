using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private float rayLength = 1;

    public LayerMask physicsLayersToSense;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.Raycast(transform.position, transform.right, rayLength, physicsLayersToSense))
        {
            Destroy(this.gameObject, 0);
        }
        
    }
}