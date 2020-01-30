using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragLOS : MonoBehaviour
{
    void OnMouseDrag() {
        
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(ray.origin, ray.direction*100f);
        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, (1<<LayerMask.NameToLayer("Ground"))))
        {
            transform.position = new Vector3(hitInfo.point.x,hitInfo.point.y + 5f,hitInfo.point.z);
        }
    }
}
