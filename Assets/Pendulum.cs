using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [Header("Параметри маятника")]
    public float maxAngle = 45f;
    public float speed = 2f;

    private Vector3 startRotation;

    void Start()
    {
        startRotation = transform.localEulerAngles;
    }

    void Update()
    {
        float currentAngle = maxAngle * Mathf.Sin(Time.time * speed);

        transform.localRotation = Quaternion.Euler(startRotation.x, startRotation.y, startRotation.z + currentAngle);
    }
}