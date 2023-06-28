using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMpvement : MonoBehaviour
{
    public float horizontalInput; 
    public float verticalInput;
    public float speed = 20.0f;

    void PlayerMovement() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        Vector3 playerMovement = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(Vector3.ClampMagnitude(playerMovement, 1) * (speed * Time.deltaTime));
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
}