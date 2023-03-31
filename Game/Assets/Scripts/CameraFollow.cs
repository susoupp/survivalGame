using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float followSpeed = 2f;
    public float yOffs = -1f;
    public Transform target;

    
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffs, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }
}
