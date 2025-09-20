using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class TouchPositonManager : MonoBehaviour
{
    public Camera camera;
    public GalaxyController galaxy;

    public Vector3 hitPoint;


    public void Update()
    {
        if (galaxy == null || camera == null) return;

        if (Input.GetMouseButtonDown(0)) {
            Vector3 clickPosition = Input.mousePosition;
            Debug.Log("Click positon: " + clickPosition);
            Ray raycastRay = camera.ScreenPointToRay(clickPosition);
            RaycastHit hit;
            if (Physics.Raycast(raycastRay, out hit, camera.farClipPlane)) {
                hitPoint = hit.point;
                galaxy.SetImpact(hitPoint);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(hitPoint, 1f);
    }

}
