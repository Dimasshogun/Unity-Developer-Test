using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    //public GameObject player;
    //public float jarak;
    public Transform targetCamera;
    public float smootSpeed;
    public Vector3 cameraOffset;

   
    void FixedUpdate()
    {
        Vector3 desiredPos = targetCamera.position + cameraOffset;
        Vector3 smootPos = Vector3.Lerp(transform.position, desiredPos, smootSpeed);

        transform.position = smootPos;
        transform.LookAt(targetCamera);
    }
}
