using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float Followspeed = 1.25f;
    public Transform target;


    private void LateUpdate()
    {
        if(!target) return;
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, Followspeed * Time.deltaTime);

    }


    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

}
