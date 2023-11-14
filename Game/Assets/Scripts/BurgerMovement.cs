using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerMovement : MonoBehaviour
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
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        transform.position = mousePos;
    }
}
