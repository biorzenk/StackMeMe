using UnityEngine;

public class GroundCheckGizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;   
        Gizmos.DrawWireSphere(transform.position, 0.15f);
    }
}
