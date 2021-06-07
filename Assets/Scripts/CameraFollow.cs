using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public bool shouldRotate = true;


    //public Transform target;

    //public float distance = 10.0f;

    //public float height = 5.0f;

    //public float heightDamping = 2.0f;
    //public float rotationDamping = 3.0f;
    //float wantedRotationAngle;
    //float wantedHeight;
    //float currentRotationAngle;
    //float currentHeight;
    //Quaternion currentRotation;

    //void LateUpdate()
    //{
    //    if (target)
    //    {

    //        wantedRotationAngle = target.eulerAngles.y;
    //        wantedHeight = target.position.y + height;
    //        currentRotationAngle = transform.eulerAngles.y;
    //        currentHeight = transform.position.y;

    //        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

    //        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

    //        currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

    //        transform.position = target.position;
    //        transform.position -= currentRotation * Vector3.forward * distance;

    //        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

    //        if (shouldRotate)
    //            transform.LookAt(target);
    //    }

    //}
    [SerializeField] 
    public GameObject player; 
    public float smoothTime = 0.2f;
    private Vector3 velocity = Vector3.zero;
    public Vector3 offset;

   

    void FixedUpdate()
    {
        offset = new Vector3(0, 2, -2.5f);

        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref velocity, smoothTime);
    }
}
