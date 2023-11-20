using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
        isRotating ^= true;     //Update rotation on mouse click 
    }
}
