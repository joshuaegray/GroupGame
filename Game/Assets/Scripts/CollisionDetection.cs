using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public string deathTag;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(deathTag))
        {
            Debug.Log("Player dying, hit: " + other.gameObject.name);
            Destroy(this.gameObject, 1);
        }
    }
}
