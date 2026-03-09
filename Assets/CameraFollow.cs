using UnityEngine;

public class CameraFollow : MonoBehaviour
{
 
    public Transform target;

    [Header("Налаштування відступу")]
    public Vector3 offset = new Vector3(0f, 3f, -6f);

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + target.TransformDirection(offset);
            transform.LookAt(target);
        }
    }
}