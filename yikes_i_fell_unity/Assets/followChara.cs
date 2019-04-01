using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followChara : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 dPos = target.position + offset;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, smoothSpeed);
        transform.position = sPos;
    }
}
