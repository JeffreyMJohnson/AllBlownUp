using UnityEngine;
using System.Collections;

public class Attach : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, -transform.up * 10);
    }
    
    void FixedUpdate()
    {
        int layerMask = 1 << 8;//only use the Attachable layer
        RaycastHit[] hits = Physics.RaycastAll(transform.position, -transform.up, layerMask);
        foreach(RaycastHit hit in hits)
        {
            float distance = hit.distance;
            transform.position += -transform.up * (hit.distance - .01f);
            transform.parent = hit.transform;
        }
    }
}
