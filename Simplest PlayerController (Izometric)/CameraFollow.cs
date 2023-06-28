using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    public Vector3 moveOffset = new Vector3(0, 25, 0);
    private Vector3 relativePosition;
    private float cameraFollowSpd = 20;


    void Start()
    {
    }
    
    void LateUpdate()
    {
        relativePosition = Player.transform.position - transform.position;
        transform.position = Vector3.Lerp(transform.position, Player.transform.TransformPoint(moveOffset), cameraFollowSpd * Time.deltaTime);
    }
}
