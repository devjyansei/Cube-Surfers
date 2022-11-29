using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(this.transform.position, target.position + offset, Time.deltaTime);
    }
}
