using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private Vector3 mousePos;

    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {

        cam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;
        }
        
    }
}
