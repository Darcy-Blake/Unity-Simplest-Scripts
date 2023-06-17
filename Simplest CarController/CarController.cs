using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 75.0f;

    // Use Unity "Input Manager" to change movement input buttons
    private float horisontalInput;
    private float verticalInput; 

    void Start()
    {
        
    }

    void LateUpdate()
    {
        horisontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); 

        // Move vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * (speed * verticalInput));
        
        if (verticalInput != 0) {
            transform.Rotate(Vector3.up, Time.deltaTime * (turnSpeed * horisontalInput * verticalInput));
        } 
        
    }
}
