using UnityEngine;

public class CameraTargetFollow : MonoBehaviour
{
    public Transform playerRoot;
    public Vector3 offset = new Vector3(0, 1.5f, 0); // adjust Y for height

    void LateUpdate()
    {
        transform.position = playerRoot.position + offset;
    }
}
