using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The player's transform to follow
    public Vector3 offset;   // The offset of the camera from the player
    public float smoothSpeed = 0.125f; // How smoothly the camera follows

    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target); // Make the camera look at the player
    }
}