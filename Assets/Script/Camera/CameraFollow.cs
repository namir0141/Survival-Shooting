using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;

    public Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;

    }
    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(target.position, targetCamPos, smoothing*Time.deltaTime);
    }

}