using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject car;
    public Vector3 moveOffset = new Vector3(0, 7, -9); // Camera Position
    private float cameraFollowSpd = 10;
    private float cameraRotationSpd = 10;

    Vector3 relativePosition;
    Quaternion targetRotation;

    void Start()
    {
        
    }
    
    void LateUpdate()
    {
        relativePosition = car.transform.position - transform.position;
        targetRotation = Quaternion.LookRotation(relativePosition);

        transform.position = Vector3.Lerp(transform.position, car.transform.TransformPoint(moveOffset), cameraFollowSpd * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, cameraRotationSpd * Time.deltaTime);
    }
}
